namespace Accounts_Holder.View
{
    partial class FormUserData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserData));
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.GBoxAccount = new System.Windows.Forms.GroupBox();
            this.LLabelShowOrHidePassword = new System.Windows.Forms.LinkLabel();
            this.ImageShowOrHidePassword = new System.Windows.Forms.PictureBox();
            this.ImageIcon = new System.Windows.Forms.PictureBox();
            this.LLabelCancel = new System.Windows.Forms.LinkLabel();
            this.LLabelOK = new System.Windows.Forms.LinkLabel();
            this.LLabelBrowse = new System.Windows.Forms.LinkLabel();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.ImageUserAvatar = new System.Windows.Forms.PictureBox();
            this.ContextMenuUserAvatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemSelectImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemResetImage = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageBrowse = new System.Windows.Forms.PictureBox();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.GBoxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
            this.PanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUserAvatar)).BeginInit();
            this.ContextMenuUserAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(71, 51);
            this.TextPassword.MaxLength = 10;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(123, 23);
            this.TextPassword.TabIndex = 8;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(9, 56);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 15);
            this.LabelPassword.TabIndex = 7;
            this.LabelPassword.Text = "Пароль:";
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(71, 22);
            this.TextLogin.MaxLength = 10;
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(123, 23);
            this.TextLogin.TabIndex = 6;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(14, 26);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(48, 15);
            this.LabelLogin.TabIndex = 5;
            this.LabelLogin.Text = "Логин:";
            // 
            // GBoxAccount
            // 
            this.GBoxAccount.Controls.Add(this.LLabelShowOrHidePassword);
            this.GBoxAccount.Controls.Add(this.ImageShowOrHidePassword);
            this.GBoxAccount.Controls.Add(this.TextLogin);
            this.GBoxAccount.Controls.Add(this.ImageIcon);
            this.GBoxAccount.Controls.Add(this.LabelLogin);
            this.GBoxAccount.Controls.Add(this.TextPassword);
            this.GBoxAccount.Controls.Add(this.LabelPassword);
            this.GBoxAccount.Location = new System.Drawing.Point(12, 91);
            this.GBoxAccount.Name = "GBoxAccount";
            this.GBoxAccount.Size = new System.Drawing.Size(261, 109);
            this.GBoxAccount.TabIndex = 10;
            this.GBoxAccount.TabStop = false;
            this.GBoxAccount.Text = "Учетные данные";
            // 
            // LLabelShowOrHidePassword
            // 
            this.LLabelShowOrHidePassword.AutoSize = true;
            this.LLabelShowOrHidePassword.Location = new System.Drawing.Point(94, 82);
            this.LLabelShowOrHidePassword.Name = "LLabelShowOrHidePassword";
            this.LLabelShowOrHidePassword.Size = new System.Drawing.Size(106, 15);
            this.LLabelShowOrHidePassword.TabIndex = 14;
            this.LLabelShowOrHidePassword.TabStop = true;
            this.LLabelShowOrHidePassword.Text = "Показать пароль";
            this.LLabelShowOrHidePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelShowOrHidePassword_LinkClicked);
            // 
            // ImageShowOrHidePassword
            // 
            this.ImageShowOrHidePassword.Image = global::Accounts_Holder.Properties.Resources.show;
            this.ImageShowOrHidePassword.Location = new System.Drawing.Point(71, 80);
            this.ImageShowOrHidePassword.Name = "ImageShowOrHidePassword";
            this.ImageShowOrHidePassword.Size = new System.Drawing.Size(20, 20);
            this.ImageShowOrHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageShowOrHidePassword.TabIndex = 13;
            this.ImageShowOrHidePassword.TabStop = false;
            // 
            // ImageIcon
            // 
            this.ImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImageIcon.Image")));
            this.ImageIcon.Location = new System.Drawing.Point(200, 23);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Size = new System.Drawing.Size(50, 50);
            this.ImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageIcon.TabIndex = 9;
            this.ImageIcon.TabStop = false;
            // 
            // LLabelCancel
            // 
            this.LLabelCancel.AutoSize = true;
            this.LLabelCancel.Location = new System.Drawing.Point(333, 154);
            this.LLabelCancel.Name = "LLabelCancel";
            this.LLabelCancel.Size = new System.Drawing.Size(68, 15);
            this.LLabelCancel.TabIndex = 14;
            this.LLabelCancel.TabStop = true;
            this.LLabelCancel.Text = "Отменить";
            this.LLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCancel_LinkClicked);
            // 
            // LLabelOK
            // 
            this.LLabelOK.AutoSize = true;
            this.LLabelOK.Location = new System.Drawing.Point(333, 119);
            this.LLabelOK.Name = "LLabelOK";
            this.LLabelOK.Size = new System.Drawing.Size(76, 15);
            this.LLabelOK.TabIndex = 12;
            this.LLabelOK.TabStop = true;
            this.LLabelOK.Text = "Применить";
            this.LLabelOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelOK_LinkClicked);
            // 
            // LLabelBrowse
            // 
            this.LLabelBrowse.AutoSize = true;
            this.LLabelBrowse.LinkColor = System.Drawing.Color.White;
            this.LLabelBrowse.Location = new System.Drawing.Point(91, 14);
            this.LLabelBrowse.Name = "LLabelBrowse";
            this.LLabelBrowse.Size = new System.Drawing.Size(68, 15);
            this.LLabelBrowse.TabIndex = 17;
            this.LLabelBrowse.TabStop = true;
            this.LLabelBrowse.Text = "Выбрать...";
            this.LLabelBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelBrowse_LinkClicked);
            // 
            // TextUserName
            // 
            this.TextUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextUserName.BackColor = System.Drawing.Color.Lavender;
            this.TextUserName.Font = new System.Drawing.Font("Cambria", 14F);
            this.TextUserName.Location = new System.Drawing.Point(248, 37);
            this.TextUserName.MaxLength = 15;
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(245, 29);
            this.TextUserName.TabIndex = 19;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Cambria", 14F);
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelUserName.Location = new System.Drawing.Point(68, 40);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(175, 22);
            this.LabelUserName.TabIndex = 18;
            this.LabelUserName.Text = "Имя пользователя:";
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelGeneral.Controls.Add(this.ImageUserAvatar);
            this.PanelGeneral.Controls.Add(this.TextUserName);
            this.PanelGeneral.Controls.Add(this.ImageBrowse);
            this.PanelGeneral.Controls.Add(this.LabelUserName);
            this.PanelGeneral.Controls.Add(this.LLabelBrowse);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(505, 77);
            this.PanelGeneral.TabIndex = 20;
            // 
            // ImageUserAvatar
            // 
            this.ImageUserAvatar.ContextMenuStrip = this.ContextMenuUserAvatar;
            this.ImageUserAvatar.Image = global::Accounts_Holder.Properties.Resources.user;
            this.ImageUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.ImageUserAvatar.Name = "ImageUserAvatar";
            this.ImageUserAvatar.Size = new System.Drawing.Size(50, 50);
            this.ImageUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageUserAvatar.TabIndex = 15;
            this.ImageUserAvatar.TabStop = false;
            // 
            // ContextMenuUserAvatar
            // 
            this.ContextMenuUserAvatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSelectImage,
            this.MenuItemResetImage});
            this.ContextMenuUserAvatar.Name = "ContextMenuUserAvatar";
            this.ContextMenuUserAvatar.Size = new System.Drawing.Size(208, 70);
            // 
            // MenuItemSelectImage
            // 
            this.MenuItemSelectImage.Image = global::Accounts_Holder.Properties.Resources.open;
            this.MenuItemSelectImage.Name = "MenuItemSelectImage";
            this.MenuItemSelectImage.Size = new System.Drawing.Size(207, 22);
            this.MenuItemSelectImage.Text = "Выбрать изображение...";
            this.MenuItemSelectImage.Click += new System.EventHandler(this.MenuItemSelectImage_Click);
            // 
            // MenuItemResetImage
            // 
            this.MenuItemResetImage.Image = global::Accounts_Holder.Properties.Resources.close;
            this.MenuItemResetImage.Name = "MenuItemResetImage";
            this.MenuItemResetImage.Size = new System.Drawing.Size(207, 22);
            this.MenuItemResetImage.Text = "Сбросить";
            this.MenuItemResetImage.Click += new System.EventHandler(this.MenuItemResetImage_Click);
            // 
            // ImageBrowse
            // 
            this.ImageBrowse.Image = global::Accounts_Holder.Properties.Resources.open_white;
            this.ImageBrowse.Location = new System.Drawing.Point(68, 12);
            this.ImageBrowse.Name = "ImageBrowse";
            this.ImageBrowse.Size = new System.Drawing.Size(20, 20);
            this.ImageBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBrowse.TabIndex = 16;
            this.ImageBrowse.TabStop = false;
            // 
            // ImageCancel
            // 
            this.ImageCancel.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageCancel.Location = new System.Drawing.Point(310, 152);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(20, 20);
            this.ImageCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCancel.TabIndex = 13;
            this.ImageCancel.TabStop = false;
            // 
            // ImageOK
            // 
            this.ImageOK.Image = global::Accounts_Holder.Properties.Resources.ok;
            this.ImageOK.Location = new System.Drawing.Point(310, 117);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(20, 20);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOK.TabIndex = 11;
            this.ImageOK.TabStop = false;
            // 
            // FormUserData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 214);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.LLabelCancel);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.LLabelOK);
            this.Controls.Add(this.ImageOK);
            this.Controls.Add(this.GBoxAccount);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные пользователя";
            this.GBoxAccount.ResumeLayout(false);
            this.GBoxAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
            this.PanelGeneral.ResumeLayout(false);
            this.PanelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUserAvatar)).EndInit();
            this.ContextMenuUserAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.PictureBox ImageIcon;
        private System.Windows.Forms.GroupBox GBoxAccount;
        private System.Windows.Forms.LinkLabel LLabelShowOrHidePassword;
        private System.Windows.Forms.PictureBox ImageShowOrHidePassword;
        private System.Windows.Forms.LinkLabel LLabelCancel;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.LinkLabel LLabelOK;
        private System.Windows.Forms.PictureBox ImageOK;
        private System.Windows.Forms.PictureBox ImageUserAvatar;
        private System.Windows.Forms.LinkLabel LLabelBrowse;
        private System.Windows.Forms.PictureBox ImageBrowse;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.ContextMenuStrip ContextMenuUserAvatar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSelectImage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemResetImage;
    }
}