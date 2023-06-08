using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Accounts_Holder.View.Widgets
{
    public partial class WidgetAccountTile : UserControl
    {
        public enum ColorMode
        {
            White,
            Blue,
            Dark
        }


        private string password = "";

        private int __user_id;
        private Model.Group __mygroup;
        private Model.AccountData _accData;


        // Constructor
        public WidgetAccountTile(Model.AccountData __data_, int __user_id_, Model.Group __myGroup_)
        {
            InitializeComponent();

            _accData = __data_;
            __user_id = __user_id_;
            __mygroup = __myGroup_;

            AccountIcon = _accData.Icon;
            AccountName = _accData.Name;
            UserLogin = _accData.AccountLogin;
            UserPassword = new string('*', _accData.AccountPassword.Length);

            GroupName = __mygroup.Name;
            GroupIcon = __mygroup.IconView;

            SetColorMode(ColorMode.Blue);
        }


        public Model.AccountData MyAccount => _accData;
        public int GroupID => __mygroup.ID;
        public string AccountName { set { Label_AccountName.Text = value; } }
        public string GroupName { set { LLabel_GroupName.Text = value; } }
        public string UserLogin { set { Label_Login.Text = value; } }
        public string UserPassword { set { Text_Password.Text = value; } }
        public Image GroupIcon { set { if (value != null) Image_GroupIcon.Image = value; } }
        public Image AccountIcon { set { if (value != null) Image_AccountIcon.Image = value; } }

        public void SetColorMode(ColorMode __mode_)
        {
            switch (__mode_)
            {
                case ColorMode.White:
                    BackColor = Text_Password.BackColor = Color.White;
                    Panel_Top.BackColor = ToolsMenu.BackColor = Color.FromArgb(238, 238, 242);
                    Label_Login.ForeColor = Color.Black;
                    Text_Password.ForeColor = Color.FromArgb(192, 0, 192);
                    Label_AccountName.ForeColor = Color.FromArgb(0, 0, 192);
                    LLabel_GroupName.LinkColor = Color.Black;
                    LLabelShowOrHidePassword.LinkColor = Color.FromArgb(0, 0, 255);
                    break;
                case ColorMode.Blue:
                    BackColor = Text_Password.BackColor = Color.FromArgb(247, 249, 254);
                    Panel_Top.BackColor = ToolsMenu.BackColor = Color.FromArgb(64, 86, 141);
                    Label_Login.ForeColor = Color.Black;
                    Text_Password.ForeColor = Color.FromArgb(192, 0, 192);
                    Label_AccountName.ForeColor = Color.White;
                    LLabel_GroupName.LinkColor = Color.WhiteSmoke;
                    LLabelShowOrHidePassword.LinkColor = Color.FromArgb(68, 82, 123);
                    break;
                case ColorMode.Dark:
                    BackColor = Text_Password.BackColor = Color.FromArgb(30, 30, 30);
                    Panel_Top.BackColor = ToolsMenu.BackColor = Color.FromArgb(51, 51, 55);
                    Label_Login.ForeColor = Color.FromArgb(122, 193, 255);
                    Text_Password.ForeColor = Color.FromArgb(192, 0, 192);
                    Label_AccountName.ForeColor = Color.White;
                    LLabel_GroupName.LinkColor = Color.FromArgb(63, 192, 156);
                    LLabelShowOrHidePassword.LinkColor = Color.FromArgb(0, 151, 251);
                    break;
            }
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void LLabelShowOrHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            
            Text_Password.UseSystemPasswordChar = !Text_Password.UseSystemPasswordChar;
            if (Text_Password.UseSystemPasswordChar)
            {
                LLabelShowOrHidePassword.Text = "Показать пароль";
                ImageShowOrHidePassword.Image = Properties.Resources.show;
            }
            else
            {
                Timer t = new Timer();
                t.Interval = 10000;
                t.Tick += t_tick;

                if (string.IsNullOrWhiteSpace(password))
                    {
                    
                    t.Start();

                    password = _accData.DecryptPassword();
                        UserPassword = password;
                    
                }
                
                    /*LLabelShowOrHidePassword.Text = "Спрятать пароль";
                    ImageShowOrHidePassword.Image = Properties.Resources.hide;*/


                if (Text_Password.UseSystemPasswordChar == true) { t.Stop();
        
                }
                
                LLabelShowOrHidePassword.Text = "Спрятать пароль";
                ImageShowOrHidePassword.Image = Properties.Resources.hide;
            }
        }

      private void t_tick (object sender, EventArgs e)
        {
            Text_Password.UseSystemPasswordChar = true;
            LLabelShowOrHidePassword.Text = "Показать пароль";
            ImageShowOrHidePassword.Image = Properties.Resources.show;
        }
        private void TSMButtonEdit_Click(object sender, System.EventArgs e)
        {
            // Edit operation
            FormAccountData formAccountData =
                new FormAccountData(__user_id, null, __noGroupsAdd_: true);

            formAccountData.AccountName = _accData.Name;
            formAccountData.UrlSource = _accData.IconUrl;
            if (!_accData.UseUrl) formAccountData.ImageSource = _accData.Icon;
            formAccountData.AccountLogin = _accData.AccountLogin;
            formAccountData.AccountPassword = _accData.DecryptPassword();

            // Show dialog
            DialogResult dr = formAccountData.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                // Read some values
                string _encryptedPassword = Model.AccountData
                    .Encrypt(formAccountData.AccountPassword, formAccountData.AccountLogin);

                // Try to Edit data in DB
                string res = Sys.AppCtrl.EditAccountData(
                   formAccountData.AccountName,
                   formAccountData.UseUrlSource,
                   formAccountData.UrlSource,
                   formAccountData.ImageSource,
                   __mygroup.ID,
                   formAccountData.AccountLogin,
                   _encryptedPassword,
                   _accData.ID
                );

                // Анализ результата обновления аккаунта в БД
                string err_text = "";
                if (res == string.Empty) // выполнено без ошибок
                {
                    _accData.SetValues(
                            formAccountData.AccountName,
                            formAccountData.ImageSource,
                            formAccountData.UseUrlSource,
                            formAccountData.UrlSource,
                            formAccountData.AccountLogin,
                            _encryptedPassword
                        );

                    // Update view
                    AccountIcon = _accData.Icon;
                    AccountName = _accData.Name;
                    UserLogin = _accData.AccountLogin;
                    UserPassword = formAccountData.AccountPassword;
                }
                else err_text = res;

                // Вывод ошибки, если возникла
                if (err_text != string.Empty)
                    MessageBox.Show($"Обновление записи аккаунта не выполнено!" +
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

        private void TSMButtonDelete_Click(object sender, System.EventArgs e)
        {
            // Confirmation
            if (MessageBox.Show($"Вы действительно хотите удалить данные аккаунта '{_accData.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Try to delete from DB
            string res = Sys.AppCtrl.DeleteAccountData(_accData.ID);

            // Анализ результата удаления аккаунта из БД
            string err_text = "";
            if (res == string.Empty) // выполнено без ошибок
            {
                // Delete from list
                __mygroup.DeleteAccount(_accData.ID);

                // Delete visual component
                Parent.Controls.Remove(this);
            }
            else err_text = res;

            // Вывод ошибки, если возникла
            if (err_text != string.Empty)
                MessageBox.Show($"Удаление записи аккаунта не выполнено!" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Система выдала сообщение об ошибке:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    Sys.CurrentErrorString,
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LLabel_GroupName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMoveToGroup formMove = new FormMoveToGroup(__user_id, __mygroup.ID);
            if (formMove.ShowDialog() == DialogResult.OK)
            {
                // Try to edit in DB
                string res = Sys.AppCtrl.EditAccountGroup(formMove.SelectedGroupID, _accData.ID);

                // Анализ результата удаления аккаунта из БД
                string err_text = "";
                if (res == string.Empty) // выполнено без ошибок
                {
                    FormUserAccounts.ManagerForm.UpdateAccountMoving(this, formMove.SelectedGroupID);
                }
                else err_text = res;

                // Вывод ошибки, если возникла
                if (err_text != string.Empty)
                    MessageBox.Show($"Удаление записи аккаунта не выполнено!" +
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
    }}