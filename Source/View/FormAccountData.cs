using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Accounts_Holder.View
{
    public partial class FormAccountData : Form
    {
        // ID текущего пользователя
        readonly int _user_id;

        // Список групп, созданных пользователем
        private readonly List<Model.Group> groups = null;


        // Constructor
        public FormAccountData(int __user_id_, List<Model.Group> __groups_, bool __noGroupsAdd_ = false)
        {
            // Установить ID текущего пользователя 
            _user_id = __user_id_;
            
            // Инициализация GUI
            InitializeComponent();
            LabelGroupName.Visible = TSComboBoxGroups.Visible = 
            ImageCreateNewGroup.Visible = LLabelCreateNewGroup.Visible = !__noGroupsAdd_;

            // Загрузить список групп пользователя
            if (!__noGroupsAdd_)
            {
                groups = __groups_;
                UpdateGroupsList();
            }
        }


        public int GroupID
        {
            get => TSComboBoxGroups.SelectedValue == null
                ? 0
                : Convert.ToInt32(TSComboBoxGroups.SelectedValue);
            set { TSComboBoxGroups.SelectedValue = value; }
        }
        public string AccountName
        {
            get => TextAccountName.Text.Trim();
            set { TextAccountName.Text = value; }
        }
        public bool UseUrlSource
            => WIS_IconSelector.Mode == Widgets.WidgetImageSelector.SelectionMode.Url;
        public string UrlSource
        {
            get => WIS_IconSelector.SelectedImageUrl;
            set { WIS_IconSelector.SelectedImageUrl = value; }
        }
        public Image ImageSource
        {
            get => WIS_IconSelector.SelectedImage;
            set { WIS_IconSelector.SelectedImage = value; }
        }
        public string AccountLogin
        {
            get => TextLogin.Text.Trim();
            set { TextLogin.Text = value; }
        }
        public string AccountPassword
        {
            get => TextPassword.Text;
            set { TextPassword.Text = value; }
        }


        /// <summary>
        /// Обновление списка групп
        /// </summary>
        /// <param name="__selectedID_">Выбранная в списке группа</param>
        private void UpdateGroupsList(int __selectedID_ = 0)
        {
            // Выход, если групп нет
            if (groups == null) return;

            // Привязать список как источник данных для ComboBox
            TSComboBoxGroups.DataSource = null;
            TSComboBoxGroups.Items.Clear();
            
            TSComboBoxGroups.DataSource = groups;
            TSComboBoxGroups.ValueMember = "ID";
            TSComboBoxGroups.DisplayMember = "Name";

            // Selection
            if (__selectedID_ > 0)
                TSComboBoxGroups.SelectedValue = __selectedID_;
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        bool groups_added = false;
        private void LLabelCreateNewGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Форма создания новой группы
            FormGroupData dataForm = new FormGroupData();
            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                string res = Sys.AppCtrl.RegisterNewUserGroup(
                    dataForm.GroupName,
                    dataForm.UseUrlSource,
                    dataForm.UrlSource,
                    dataForm.ImageSource,
                    _user_id
                );

                // Анализ результата добавления группы в БД
                string err_text = "";
                if (res == string.Empty) // выполнено без ошибок
                {
                    // Create new Group
                    // Returns ID of new group
                    int newGroupID = Sys.AppCtrl.GetLastInsertedGroupID();
                    if (newGroupID > 0)
                    {
                        // Добавить группу в список
                        groups.Add(new Model.Group(
                                dataForm.GroupName,
                                dataForm.UseUrlSource ? null : dataForm.ImageSource,
                                dataForm.UseUrlSource,
                                dataForm.UrlSource,
                                newGroupID
                            ));
                        // Обновить список
                        groups_added = true;
                        UpdateGroupsList(newGroupID);
                    }
                    else err_text = Sys.CurrentErrorString;
                }
                else err_text = res;

                // Вывод ошибки, если возникла
                if (err_text != string.Empty)
                    MessageBox.Show($"Новая группа аккаунтов не была создана!" +
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

        private void LLabelGeneratePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGeneratePassword frmGenPwd = new FormGeneratePassword();
            if (frmGenPwd.ShowDialog() == DialogResult.OK)
                TextPassword.Text = frmGenPwd.GeneratedPassword;
        }

        private void LLabelShowOrHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextPassword.UseSystemPasswordChar = !TextPassword.UseSystemPasswordChar;
            if (TextPassword.UseSystemPasswordChar)
            {
                LLabelShowOrHidePassword.Text = "Показать пароль";
                ImageShowOrHidePassword.Image = Properties.Resources.show;
            }
            else
            {
                LLabelShowOrHidePassword.Text = "Спрятать пароль";
                ImageShowOrHidePassword.Image = Properties.Resources.hide;
            }
        }

        private void LLabelOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Проверки ввода
            if (string.IsNullOrWhiteSpace(AccountName))
            {
                MessageBox.Show("Введите наименование аккаунта!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TSComboBoxGroups.Visible && GroupID == 0)
            {
                MessageBox.Show("Выберите группу для аккаунта!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (AccountLogin.Length < 3 || AccountPassword.Length < 3)
            {
                MessageBox.Show("Логин / пароль для аккаунта должен состоять не меньше, чем из 3 символов",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult = groups_added ? DialogResult.Yes : DialogResult.OK;
            Close();
        }

        private void LLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}