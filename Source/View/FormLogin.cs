using System;
using System.Windows.Forms;

namespace Accounts_Holder.View
{
    public partial class FormLogin : Form
    {
        // Constructor
        public FormLogin()
        {
            InitializeComponent();
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void LLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Clear fields
            string login = TextLogin.Text.Trim();
            string password = TextPassword.Text;
            TextLogin.Text = TextPassword.Text = "";

            // Login
            Controller.User user = Sys.AppCtrl.Authorize(login, password);

            if (user.Status == string.Empty)
            {
                new FormUserAccounts()
                {
                    UserID = user.ID,
                    Login = login,
                    Password = password,
                    UserAvatar = user.Avatar,
                    UserName = $"{user.Name}"
                }.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Пользователь не авторизован!" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Причина:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    user.Status,
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLabelQuit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void LLabelRegisterNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Register new user
            FormUserData dataForm = new FormUserData();

            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                string registerUserResultText = Sys.AppCtrl.RegisterNewUser
                (
                    dataForm.UserName,
                    dataForm.UserLogin,
                    dataForm.UserPassword,
                    dataForm.UserAvatar
                );

                if (registerUserResultText == string.Empty)
                    MessageBox.Show($"Пользователь '{dataForm.UserName}' успешно зарегистрирован!",
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Пользователь '{dataForm.UserName}' не зарегистрирован!" +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Система выдала сообщение об ошибке:" +
                        Environment.NewLine +
                        Environment.NewLine +
                        registerUserResultText,
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}