namespace Accounts_Holder.View
{
    partial class FormAccountData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountData));
            this.TextAccountName = new System.Windows.Forms.TextBox();
            this.LabelAccountName = new System.Windows.Forms.Label();
            this.LLabelCancel = new System.Windows.Forms.LinkLabel();
            this.LLabelOK = new System.Windows.Forms.LinkLabel();
            this.WIS_IconSelector = new Accounts_Holder.View.Widgets.WidgetImageSelector();
            this.LabelGroupName = new System.Windows.Forms.Label();
            this.TSComboBoxGroups = new System.Windows.Forms.ComboBox();
            this.GBoxAccount = new System.Windows.Forms.GroupBox();
            this.LLabelGeneratePassword = new System.Windows.Forms.LinkLabel();
            this.ImageGeneratePassword = new System.Windows.Forms.PictureBox();
            this.LLabelShowOrHidePassword = new System.Windows.Forms.LinkLabel();
            this.ImageShowOrHidePassword = new System.Windows.Forms.PictureBox();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.ImageIcon = new System.Windows.Forms.PictureBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LLabelCreateNewGroup = new System.Windows.Forms.LinkLabel();
            this.ImageCreateNewGroup = new System.Windows.Forms.PictureBox();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.GBoxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGeneratePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCreateNewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            this.SuspendLayout();
            // 
            // TextAccountName
            // 
            this.TextAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextAccountName.BackColor = System.Drawing.Color.White;
            this.TextAccountName.Font = new System.Drawing.Font("Cambria", 10F);
            this.TextAccountName.Location = new System.Drawing.Point(186, 59);
            this.TextAccountName.MaxLength = 50;
            this.TextAccountName.Name = "TextAccountName";
            this.TextAccountName.Size = new System.Drawing.Size(410, 23);
            this.TextAccountName.TabIndex = 28;
            // 
            // LabelAccountName
            // 
            this.LabelAccountName.AutoSize = true;
            this.LabelAccountName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelAccountName.ForeColor = System.Drawing.Color.Black;
            this.LabelAccountName.Location = new System.Drawing.Point(17, 62);
            this.LabelAccountName.Name = "LabelAccountName";
            this.LabelAccountName.Size = new System.Drawing.Size(167, 16);
            this.LabelAccountName.TabIndex = 27;
            this.LabelAccountName.Text = "Наименование аккаунта:";
            // 
            // LLabelCancel
            // 
            this.LLabelCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelCancel.AutoSize = true;
            this.LLabelCancel.Location = new System.Drawing.Point(148, 262);
            this.LLabelCancel.Name = "LLabelCancel";
            this.LLabelCancel.Size = new System.Drawing.Size(68, 15);
            this.LLabelCancel.TabIndex = 26;
            this.LLabelCancel.TabStop = true;
            this.LLabelCancel.Text = "Отменить";
            this.LLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCancel_LinkClicked);
            // 
            // LLabelOK
            // 
            this.LLabelOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelOK.AutoSize = true;
            this.LLabelOK.Location = new System.Drawing.Point(43, 262);
            this.LLabelOK.Name = "LLabelOK";
            this.LLabelOK.Size = new System.Drawing.Size(76, 15);
            this.LLabelOK.TabIndex = 24;
            this.LLabelOK.TabStop = true;
            this.LLabelOK.Text = "Применить";
            this.LLabelOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelOK_LinkClicked);
            // 
            // WIS_IconSelector
            // 
            this.WIS_IconSelector.BackColor = System.Drawing.Color.White;
            this.WIS_IconSelector.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WIS_IconSelector.Location = new System.Drawing.Point(20, 99);
            this.WIS_IconSelector.Name = "WIS_IconSelector";
            this.WIS_IconSelector.SelectedImage = null;
            this.WIS_IconSelector.SelectedImageUrl = "";
            this.WIS_IconSelector.Size = new System.Drawing.Size(249, 90);
            this.WIS_IconSelector.TabIndex = 29;
            // 
            // LabelGroupName
            // 
            this.LabelGroupName.AutoSize = true;
            this.LabelGroupName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelGroupName.ForeColor = System.Drawing.Color.Black;
            this.LabelGroupName.Location = new System.Drawing.Point(25, 33);
            this.LabelGroupName.Name = "LabelGroupName";
            this.LabelGroupName.Size = new System.Drawing.Size(155, 16);
            this.LabelGroupName.TabIndex = 30;
            this.LabelGroupName.Text = "Наименование группы:";
            // 
            // TSComboBoxGroups
            // 
            this.TSComboBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSComboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSComboBoxGroups.FormattingEnabled = true;
            this.TSComboBoxGroups.Location = new System.Drawing.Point(186, 30);
            this.TSComboBoxGroups.Name = "TSComboBoxGroups";
            this.TSComboBoxGroups.Size = new System.Drawing.Size(410, 23);
            this.TSComboBoxGroups.TabIndex = 32;
            // 
            // GBoxAccount
            // 
            this.GBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBoxAccount.Controls.Add(this.LLabelGeneratePassword);
            this.GBoxAccount.Controls.Add(this.ImageGeneratePassword);
            this.GBoxAccount.Controls.Add(this.LLabelShowOrHidePassword);
            this.GBoxAccount.Controls.Add(this.ImageShowOrHidePassword);
            this.GBoxAccount.Controls.Add(this.TextLogin);
            this.GBoxAccount.Controls.Add(this.ImageIcon);
            this.GBoxAccount.Controls.Add(this.LabelLogin);
            this.GBoxAccount.Controls.Add(this.TextPassword);
            this.GBoxAccount.Controls.Add(this.LabelPassword);
            this.GBoxAccount.Location = new System.Drawing.Point(281, 99);
            this.GBoxAccount.Name = "GBoxAccount";
            this.GBoxAccount.Size = new System.Drawing.Size(315, 135);
            this.GBoxAccount.TabIndex = 33;
            this.GBoxAccount.TabStop = false;
            this.GBoxAccount.Text = "Учетные данные";
            // 
            // LLabelGeneratePassword
            // 
            this.LLabelGeneratePassword.AutoSize = true;
            this.LLabelGeneratePassword.Location = new System.Drawing.Point(94, 108);
            this.LLabelGeneratePassword.Name = "LLabelGeneratePassword";
            this.LLabelGeneratePassword.Size = new System.Drawing.Size(105, 15);
            this.LLabelGeneratePassword.TabIndex = 16;
            this.LLabelGeneratePassword.TabStop = true;
            this.LLabelGeneratePassword.Text = "Сгенерировать...";
            this.LLabelGeneratePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelGeneratePassword_LinkClicked);
            // 
            // ImageGeneratePassword
            // 
            this.ImageGeneratePassword.Image = global::Accounts_Holder.Properties.Resources.configure;
            this.ImageGeneratePassword.Location = new System.Drawing.Point(71, 106);
            this.ImageGeneratePassword.Name = "ImageGeneratePassword";
            this.ImageGeneratePassword.Size = new System.Drawing.Size(20, 20);
            this.ImageGeneratePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageGeneratePassword.TabIndex = 15;
            this.ImageGeneratePassword.TabStop = false;
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
            // TextLogin
            // 
            this.TextLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLogin.Location = new System.Drawing.Point(71, 22);
            this.TextLogin.MaxLength = 20;
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(177, 23);
            this.TextLogin.TabIndex = 6;
            // 
            // ImageIcon
            // 
            this.ImageIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImageIcon.Image")));
            this.ImageIcon.Location = new System.Drawing.Point(254, 23);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Size = new System.Drawing.Size(50, 50);
            this.ImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageIcon.TabIndex = 9;
            this.ImageIcon.TabStop = false;
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
            // TextPassword
            // 
            this.TextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPassword.Location = new System.Drawing.Point(71, 51);
            this.TextPassword.MaxLength = 20;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(177, 23);
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
            // LLabelCreateNewGroup
            // 
            this.LLabelCreateNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelCreateNewGroup.AutoSize = true;
            this.LLabelCreateNewGroup.Location = new System.Drawing.Point(448, 5);
            this.LLabelCreateNewGroup.Name = "LLabelCreateNewGroup";
            this.LLabelCreateNewGroup.Size = new System.Drawing.Size(148, 15);
            this.LLabelCreateNewGroup.TabIndex = 35;
            this.LLabelCreateNewGroup.TabStop = true;
            this.LLabelCreateNewGroup.Text = "Создать новую группу...";
            this.LLabelCreateNewGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCreateNewGroup_LinkClicked);
            // 
            // ImageCreateNewGroup
            // 
            this.ImageCreateNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCreateNewGroup.Image = global::Accounts_Holder.Properties.Resources.add;
            this.ImageCreateNewGroup.Location = new System.Drawing.Point(425, 3);
            this.ImageCreateNewGroup.Name = "ImageCreateNewGroup";
            this.ImageCreateNewGroup.Size = new System.Drawing.Size(20, 20);
            this.ImageCreateNewGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCreateNewGroup.TabIndex = 34;
            this.ImageCreateNewGroup.TabStop = false;
            // 
            // ImageCancel
            // 
            this.ImageCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageCancel.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageCancel.Location = new System.Drawing.Point(125, 260);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(20, 20);
            this.ImageCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCancel.TabIndex = 25;
            this.ImageCancel.TabStop = false;
            // 
            // ImageOK
            // 
            this.ImageOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageOK.Image = global::Accounts_Holder.Properties.Resources.ok;
            this.ImageOK.Location = new System.Drawing.Point(20, 260);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(20, 20);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOK.TabIndex = 23;
            this.ImageOK.TabStop = false;
            // 
            // FormAccountData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 296);
            this.Controls.Add(this.LLabelCreateNewGroup);
            this.Controls.Add(this.ImageCreateNewGroup);
            this.Controls.Add(this.GBoxAccount);
            this.Controls.Add(this.TSComboBoxGroups);
            this.Controls.Add(this.LabelGroupName);
            this.Controls.Add(this.WIS_IconSelector);
            this.Controls.Add(this.TextAccountName);
            this.Controls.Add(this.LabelAccountName);
            this.Controls.Add(this.LLabelCancel);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.LLabelOK);
            this.Controls.Add(this.ImageOK);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные аккаунта пользователя";
            this.GBoxAccount.ResumeLayout(false);
            this.GBoxAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGeneratePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCreateNewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAccountName;
        private System.Windows.Forms.Label LabelAccountName;
        private System.Windows.Forms.LinkLabel LLabelCancel;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.LinkLabel LLabelOK;
        private System.Windows.Forms.PictureBox ImageOK;
        private Widgets.WidgetImageSelector WIS_IconSelector;
        private System.Windows.Forms.Label LabelGroupName;
        private System.Windows.Forms.ComboBox TSComboBoxGroups;
        private System.Windows.Forms.GroupBox GBoxAccount;
        private System.Windows.Forms.LinkLabel LLabelGeneratePassword;
        private System.Windows.Forms.PictureBox ImageGeneratePassword;
        private System.Windows.Forms.LinkLabel LLabelShowOrHidePassword;
        private System.Windows.Forms.PictureBox ImageShowOrHidePassword;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.PictureBox ImageIcon;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.LinkLabel LLabelCreateNewGroup;
        private System.Windows.Forms.PictureBox ImageCreateNewGroup;
    }
}