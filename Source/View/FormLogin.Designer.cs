namespace Accounts_Holder.View
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ImageIcon = new System.Windows.Forms.PictureBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.ImageLogin = new System.Windows.Forms.PictureBox();
            this.LLabelLogin = new System.Windows.Forms.LinkLabel();
            this.LLabelQuit = new System.Windows.Forms.LinkLabel();
            this.ImageQuit = new System.Windows.Forms.PictureBox();
            this.LLabelRegisterNewUser = new System.Windows.Forms.LinkLabel();
            this.ImageRegisterNewUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRegisterNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageIcon
            // 
            this.ImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImageIcon.Image")));
            this.ImageIcon.Location = new System.Drawing.Point(53, 26);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Size = new System.Drawing.Size(50, 50);
            this.ImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageIcon.TabIndex = 0;
            this.ImageIcon.TabStop = false;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(129, 26);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(48, 15);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Логин:";
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(186, 22);
            this.TextLogin.MaxLength = 10;
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(123, 23);
            this.TextLogin.TabIndex = 2;
            this.TextLogin.Text = "aksenova";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(124, 56);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 15);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Пароль:";
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(186, 51);
            this.TextPassword.MaxLength = 10;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(123, 23);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.Text = "l_aksenova";
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // ImageLogin
            // 
            this.ImageLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageLogin.Image = global::Accounts_Holder.Properties.Resources.Login;
            this.ImageLogin.Location = new System.Drawing.Point(10, 103);
            this.ImageLogin.Name = "ImageLogin";
            this.ImageLogin.Size = new System.Drawing.Size(20, 20);
            this.ImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageLogin.TabIndex = 5;
            this.ImageLogin.TabStop = false;
            // 
            // LLabelLogin
            // 
            this.LLabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelLogin.AutoSize = true;
            this.LLabelLogin.Location = new System.Drawing.Point(33, 105);
            this.LLabelLogin.Name = "LLabelLogin";
            this.LLabelLogin.Size = new System.Drawing.Size(85, 15);
            this.LLabelLogin.TabIndex = 6;
            this.LLabelLogin.TabStop = true;
            this.LLabelLogin.Text = "Авторизация";
            this.LLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelLogin_LinkClicked);
            // 
            // LLabelQuit
            // 
            this.LLabelQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelQuit.AutoSize = true;
            this.LLabelQuit.Location = new System.Drawing.Point(147, 105);
            this.LLabelQuit.Name = "LLabelQuit";
            this.LLabelQuit.Size = new System.Drawing.Size(72, 15);
            this.LLabelQuit.TabIndex = 8;
            this.LLabelQuit.TabStop = true;
            this.LLabelQuit.Text = "Завершить";
            this.LLabelQuit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelQuit_LinkClicked);
            // 
            // ImageQuit
            // 
            this.ImageQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageQuit.Image = global::Accounts_Holder.Properties.Resources.quit;
            this.ImageQuit.Location = new System.Drawing.Point(124, 103);
            this.ImageQuit.Name = "ImageQuit";
            this.ImageQuit.Size = new System.Drawing.Size(20, 20);
            this.ImageQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageQuit.TabIndex = 7;
            this.ImageQuit.TabStop = false;
            // 
            // LLabelRegisterNewUser
            // 
            this.LLabelRegisterNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelRegisterNewUser.AutoSize = true;
            this.LLabelRegisterNewUser.Location = new System.Drawing.Point(393, 105);
            this.LLabelRegisterNewUser.Name = "LLabelRegisterNewUser";
            this.LLabelRegisterNewUser.Size = new System.Drawing.Size(82, 15);
            this.LLabelRegisterNewUser.TabIndex = 10;
            this.LLabelRegisterNewUser.TabStop = true;
            this.LLabelRegisterNewUser.Text = "Регистрация";
            this.LLabelRegisterNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelRegisterNewUser_LinkClicked);
            // 
            // ImageRegisterNewUser
            // 
            this.ImageRegisterNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageRegisterNewUser.Image = global::Accounts_Holder.Properties.Resources.register;
            this.ImageRegisterNewUser.Location = new System.Drawing.Point(370, 103);
            this.ImageRegisterNewUser.Name = "ImageRegisterNewUser";
            this.ImageRegisterNewUser.Size = new System.Drawing.Size(20, 20);
            this.ImageRegisterNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageRegisterNewUser.TabIndex = 9;
            this.ImageRegisterNewUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 132);
            this.Controls.Add(this.LLabelRegisterNewUser);
            this.Controls.Add(this.ImageRegisterNewUser);
            this.Controls.Add(this.LLabelQuit);
            this.Controls.Add(this.ImageQuit);
            this.Controls.Add(this.LLabelLogin);
            this.Controls.Add(this.ImageLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ImageIcon);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRegisterNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageIcon;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox ImageLogin;
        private System.Windows.Forms.LinkLabel LLabelLogin;
        private System.Windows.Forms.LinkLabel LLabelQuit;
        private System.Windows.Forms.PictureBox ImageQuit;
        private System.Windows.Forms.LinkLabel LLabelRegisterNewUser;
        private System.Windows.Forms.PictureBox ImageRegisterNewUser;
    }
}
