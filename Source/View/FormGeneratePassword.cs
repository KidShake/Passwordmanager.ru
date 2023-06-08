using System.Windows.Forms;

using Accounts_Holder.Utils;

namespace Accounts_Holder.View
{
    public partial class FormGeneratePassword : Form
    {
        // Constructor
        public FormGeneratePassword()
        {
            InitializeComponent();
            Label_Password.Text = "";
        }


        public string GeneratedPassword => Label_Password.Text;


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void LLabelOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Проверки ввода
            if (string.IsNullOrWhiteSpace(GeneratedPassword))
            {
                MessageBox.Show("Пароль не был сгенерирован!", Application.ProductName,
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

        private void LLabelGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pwdLength = (int)NumericSelector_Length.Value;
            PasswordGenerator pwdGenerator = new PasswordGenerator(pwdLength);
            Label_Password.Text = pwdGenerator.GeneratePassword();
        }
    }
}