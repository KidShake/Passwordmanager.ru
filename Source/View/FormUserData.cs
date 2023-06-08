using System.Windows.Forms;

namespace Accounts_Holder.View
{
    public partial class FormUserData : Form
    {
        string _oldLogin = "";

        // Constructor
        public FormUserData()
        {
            InitializeComponent();
        }


        public string UserName
        {
            get => TextUserName.Text.Trim();
            set { TextUserName.Text = value; }
        }
        public string UserLogin
        {
            get => TextLogin.Text.Trim();
            set 
            {
                _oldLogin = value;
                TextLogin.Text = value; 
            }
        }
        public string UserPassword
        {
            get => TextPassword.Text;
            set { TextPassword.Text = value; }
        }
        public System.Drawing.Image UserAvatar
        {
            get => ImageUserAvatar.Image;
            set { ImageUserAvatar.Image = value == null ? Properties.Resources.user : value; }
        }
       
        private bool loginChanged => _oldLogin != UserLogin;


        // ------- GUI Elements Commands -------------------------------------------------------------------

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
            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Введите имя пользователя!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (UserLogin.Length < 3 || UserPassword.Length < 3)
            {
                MessageBox.Show("Логин / пароль пользователя должен состоять не меньше, чем из 3 символов",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (loginChanged && Sys.AppCtrl.CheckUserForExists(UserLogin))
            {
                MessageBox.Show("Введенный логин пользователя уже занят!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void LLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MenuItemSelectImage_Click(object sender, System.EventArgs e)
        {
            System.Drawing.Image image = Sys.SelectPNGFromFile();
            if (image != null)
                ImageUserAvatar.Image = image;
        }

        private void MenuItemResetImage_Click(object sender, System.EventArgs e)
        {
            ImageUserAvatar.Image = Properties.Resources.user;
        }

        private void LLabelBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Drawing.Image image = Sys.SelectPNGFromFile();
            if (image != null)
                ImageUserAvatar.Image = image;
        }
    }
}