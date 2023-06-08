using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Accounts_Holder.View
{
    public partial class FormUserAccounts : Form
    {
        public static FormUserAccounts ManagerForm;


        // Constructor
        public FormUserAccounts()
        {
            InitializeComponent();

            ManagerForm = this;
        }


        private int _selIGID = -1;

        private int _id = 0;
        private string _login="";
        private string _name = "";
        private string _password = "";
        private Image _avatar = null;

        public int UserID { set { _id = value; } }
        public string Login { set { _login = value; } }
        public string Password { set { _password = value; } }
        public string UserName { set { LabelUserName.Text = _name = value; } }
        public Image UserAvatar { set { ImageUserAvatar.Image = _avatar = value; } }

        private List<Model.Group> groups;

        private void UpdateTiles()
        {
            // Clear visual container
            FlowPanelData.Controls.Clear();

            // ID выбранной в данный момент группы
            int selected = SelectedGroupID();

            // Add tiles by group
            foreach (var group in groups)
                foreach (var account in group.Accounts)
                    VisualizeTile(account, group, selected);
        }

        private void VisualizeTile(Model.AccountData __account_, Model.Group __group_, int __selectedID_ = -1)
        {
            // Не добавлять, если аккаунт не из выбранной группы
            int selectedID = __selectedID_ == -1 ? SelectedGroupID() : __selectedID_;

            if (selectedID != 0 && selectedID != __group_.ID) return;

            // Создать визуальную "плитку" аккаунта
            Widgets.WidgetAccountTile wacct = new Widgets.WidgetAccountTile(__account_, _id, __group_);
            wacct.SetColorMode(_currentTheme);
            FlowPanelData.Controls.Add(wacct);
        }

        public void LoadUserGroupsToList()
        {
            // Load Groups
            List<Model.Group> loaded = Sys.AppCtrl.GetGroupsTableWithData(_id);

            // Update existing list or create new
            if (groups == null)
                groups = Sys.AppCtrl.GetGroupsTableWithData(_id);
            else
                foreach (var item in Sys.AppCtrl.GetGroupsTableWithData(_id))
                    if (!groups.Contains(item))
                        groups.Add(item);

            // Clear Deleted Items
            groups.RemoveAll(_gr => !loaded.Contains(_gr));
        }

        private void FillGroupList(int selection_index = -1, bool __loadAccounts_ = true)
        {
            TSComboBoxGroups.Items.Clear();
            TSComboBoxGroups.Items.Add($"0: Все");

            if (groups == null) return;

            foreach (var item in groups)
            {
                // Добавить группу аккаунтов в список
                TSComboBoxGroups.Items.Add($"{item.ID}: {item.Name}");

                // Загрузить аккаунты группы
                if (__loadAccounts_)
                {
                    List<Model.AccountData> accounts = Sys.AppCtrl.GetGroupAccounts(item.ID);
                    if (accounts != null)
                        item.AddAccounts(accounts);
                }
            }

            // Выделить группу в списке
            int index = selection_index;
            if (selection_index != -1)
            {
                while (index > TSComboBoxGroups.Items.Count - 1) index--;

                TSComboBoxGroups.SelectedIndex = index;
            }
        }

        private int SelectedGroupID()
            => TSComboBoxGroups.SelectedIndex > 0
                ? Convert.ToInt32(TSComboBoxGroups.Text.Split(':')[0])
                : 0;

        public void UpdateAccountMoving(Widgets.WidgetAccountTile __tile_, int __destination_Group_ID_)
        {
            // Create Account Clone
            Model.AccountData _acc = Model.AccountData.Clone(__tile_.MyAccount);

            // Delete from source list
            Model.Group src_group = groups.Find(g => g.HasID(__tile_.GroupID));
            src_group.DeleteAccount(__tile_.MyAccount.ID);
            FlowPanelData.Controls.Remove(__tile_);

            // Move to destinantion list
            Model.Group dst_group = groups.Find(g => g.HasID(__destination_Group_ID_));
            dst_group.AddAccounts(_acc);

            // Добавить визуальный компонент
            VisualizeTile(_acc, dst_group);
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void FormUserAccounts_Load(object sender, EventArgs e)
        {
            LoadUserGroupsToList();
            FillGroupList();

            TSComboBoxGroups.SelectedIndex = 0;

            UpdateTiles();

            SetTheme(Widgets.WidgetAccountTile.ColorMode.White);
        }

        private void TSMButtonAddAccount_Click(object sender, System.EventArgs e)
        {
            // ID текущей группы
            int listIndex = TSComboBoxGroups.SelectedIndex;
            int g_id = SelectedGroupID(); 

            // Add operation
            FormAccountData formAccountData = new FormAccountData(_id, groups);
            if (g_id > 0) formAccountData.GroupID = g_id;
            
            // Show dialog
            DialogResult dr = formAccountData.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                // Create new data
                int group_id = formAccountData.GroupID;
                Model.AccountData acc = new Model.AccountData(
                        formAccountData.AccountName,
                        formAccountData.ImageSource,
                        formAccountData.UseUrlSource,
                        formAccountData.UrlSource,
                        formAccountData.AccountLogin,
                        formAccountData.AccountPassword
                    );
                acc.EncryptByLogin();

                // Добавление аккаунта в БД
                string res = Sys.AppCtrl.RegisterNewAccount(
                    acc.Name, 
                    acc.UseUrl, 
                    acc.IconUrl, 
                    acc.Icon,
                    group_id, 
                    acc.AccountLogin, 
                    acc.AccountPassword
                );

                // Анализ результата добавления аккаунта в БД
                string err_text = "";
                if (res == string.Empty) // выполнено без ошибок
                {
                    // Create new Account
                    // Returns ID of new Account
                    int newAccountID = Sys.AppCtrl.GetLastInsertdAccountID();
                    if (newAccountID > 0)
                    {
                        // Установить ID
                        acc.SetID(newAccountID);
                        
                        // Если была создана новая группа
                        if (dr == DialogResult.Yes)
                        {
                            LoadUserGroupsToList();
                            FillGroupList(listIndex, __loadAccounts_: false);
                        }

                        // Добавить аккаунт в список группы
                        Model.Group group = groups.Find(g => g.HasID(group_id));
                        group.AddAccounts(acc); 

                        // Добавить визуальный компонент
                        VisualizeTile(acc, group);
                    }
                    else err_text = Sys.CurrentErrorString;
                }
                else err_text = res;

                // Вывод ошибки, если возникла
                if (err_text != string.Empty)
                    MessageBox.Show($"Новая запись аккаунта не была создана!" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Система выдала сообщение об ошибке:" +
                        Environment.NewLine +
                        Environment.NewLine +
                        Sys.CurrentErrorString,
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMButtonGroupsDictionary_Click(object sender, System.EventArgs e)
        {
            int index = TSComboBoxGroups.SelectedIndex;

            // Run Dictionary Window
            FormGroups formGroups = new FormGroups(_id);
            formGroups.ShowDialog();

            // Update group list
            if (formGroups.ChangedVolume == FormGroups.DictionaryChangeType.AddedOrEdited)
            {
                LoadUserGroupsToList();
                FillGroupList(index, __loadAccounts_: false);
            }
            // Update group list && Tiles
            else if (formGroups.ChangedVolume == FormGroups.DictionaryChangeType.Deleted ||
                     formGroups.ChangedVolume == FormGroups.DictionaryChangeType.Mixed)
            {
                LoadUserGroupsToList();
                FillGroupList(index, __loadAccounts_: false);
                UpdateTiles();
            }
        }

        private void TSMButtonPrintReport_Click(object sender, System.EventArgs e)
        {
            // Get HTML Report
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<HTML>")
              .AppendLine("<HEAD></HEAD>")
              .AppendLine("<BODY>")
              .AppendLine("<TABLE width=100% cellspadding=0 cellspacing=0 border=all>")
              .AppendLine("<TR>")
              .AppendLine("<TD align=center><B>Account Name</B></TD>")
              .AppendLine("<TD align=center><B>Login</B></TD>")
              .AppendLine("<TD align=center><B>Password</B></TD>")
              .AppendLine("</TR>");

            int c_gr = SelectedGroupID();
            
            if (c_gr > 0)
                sb.AppendLine(groups.Find(g => g.HasID(c_gr)).GetHTMLListContent());
            else
                groups.ForEach(g => sb.AppendLine(g.GetHTMLListContent()));

            sb.AppendLine("</TABLE>");

            Form frmList = new Form()
            {
                Text = "Password's list",
                Icon = this.Icon,
                Width = 500,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false
            };
            WebBrowser wbb = new WebBrowser() { DocumentText = sb.ToString() };
            frmList.Controls.Add(wbb);
            wbb.Dock = DockStyle.Fill;

            frmList.ShowDialog();
        }



        private void LLabelEditMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Update user data
            FormUserData dataForm = new FormUserData()
            {
                UserLogin = _login,
                UserPassword = _password,
                UserAvatar = _avatar,
                UserName = _name
            };

            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                string _n_name = dataForm.UserName;
                string _n_login = dataForm.UserLogin;
                string _n_password = dataForm.UserPassword;
                Image _n_avatar = dataForm.UserAvatar;

                string result = Sys.AppCtrl.EditCurrentUserData(_n_name, _n_login, _n_password, _n_avatar,
                                 _login, _id);

                if (result == string.Empty)
                {
                    Login = _n_login;
                    UserName = _n_name;
                    Password = _n_password;
                    UserAvatar = _n_avatar;
                }
                else
                    MessageBox.Show($"Не удалось изменить данные пользователя" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Система выдала сообщение об ошибке:" +
                        Environment.NewLine +
                        Environment.NewLine +
                        result,
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLabelDeleteMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить свой аккаунт? " +
                "При этом все ваши пароли будут удалены безвозвратно?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string result = Sys.AppCtrl.DeleteUserData(_id);

                if (result == string.Empty)
                    Close();
                else
                    MessageBox.Show($"Данные текущего пользователя не удалены!" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Причина:" +
                        Environment.NewLine +
                        Environment.NewLine +
                        result,
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSComboBoxCroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = SelectedGroupID();

            if (si == _selIGID) return;

            UpdateTiles();

            _selIGID = si;
        }

        private void TSMButtonGroupsShowAll_Click(object sender, EventArgs e)
        {
            TSComboBoxGroups.SelectedIndex = 0;
            UpdateTiles();
        }

        // Color theme selection -----------------------------------------------

        Widgets.WidgetAccountTile.ColorMode _currentTheme =
            Widgets.WidgetAccountTile.ColorMode.White;
        private void TSMButtonCSWhite_Click(object sender, System.EventArgs e)
        {
            SetTheme(Widgets.WidgetAccountTile.ColorMode.White);
        }
        private void TSMButtonCSBlue_Click(object sender, System.EventArgs e)
        {
            SetTheme(Widgets.WidgetAccountTile.ColorMode.Blue);
        }
        private void TSMButtonCSDark_Click(object sender, System.EventArgs e)
        {
            SetTheme(Widgets.WidgetAccountTile.ColorMode.Dark);
        }
        private void SetTheme(Widgets.WidgetAccountTile.ColorMode __cmode_)
        {
            _currentTheme = __cmode_;
            switch (__cmode_)
            {
                case Widgets.WidgetAccountTile.ColorMode.White:
                    FlowPanelData.BackColor = Color.FromArgb(238, 238, 242);
                    foreach (Widgets.WidgetAccountTile tile in FlowPanelData.Controls)
                        tile.SetColorMode(Widgets.WidgetAccountTile.ColorMode.White);
                    break;
                case Widgets.WidgetAccountTile.ColorMode.Blue:
                    FlowPanelData.BackColor = Color.FromArgb(64, 86, 141);
                    foreach (Widgets.WidgetAccountTile tile in FlowPanelData.Controls)
                        tile.SetColorMode(Widgets.WidgetAccountTile.ColorMode.Blue);
                    break;
                case Widgets.WidgetAccountTile.ColorMode.Dark:
                    FlowPanelData.BackColor = Color.FromArgb(51, 51, 55);
                    foreach (Widgets.WidgetAccountTile tile in FlowPanelData.Controls)
                        tile.SetColorMode(Widgets.WidgetAccountTile.ColorMode.Dark);
                    break;
            }
        }
    }
}