namespace Accounts_Holder.View.Widgets
{
    partial class WidgetAccountTile
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.LLabel_GroupName = new System.Windows.Forms.LinkLabel();
            this.Label_AccountName = new System.Windows.Forms.Label();
            this.Image_GroupIcon = new System.Windows.Forms.PictureBox();
            this.ToolsMenu = new System.Windows.Forms.ToolStrip();
            this.TSMButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.TSMButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.LLabelShowOrHidePassword = new System.Windows.Forms.LinkLabel();
            this.ImageShowOrHidePassword = new System.Windows.Forms.PictureBox();
            this.Image_AccountIcon = new System.Windows.Forms.PictureBox();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_GroupIcon)).BeginInit();
            this.ToolsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_AccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Panel_Top.Controls.Add(this.LLabel_GroupName);
            this.Panel_Top.Controls.Add(this.Label_AccountName);
            this.Panel_Top.Controls.Add(this.Image_GroupIcon);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(280, 31);
            this.Panel_Top.TabIndex = 0;
            // 
            // LLabel_GroupName
            // 
            this.LLabel_GroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LLabel_GroupName.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic);
            this.LLabel_GroupName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.LLabel_GroupName.Location = new System.Drawing.Point(31, 17);
            this.LLabel_GroupName.Name = "LLabel_GroupName";
            this.LLabel_GroupName.Size = new System.Drawing.Size(249, 12);
            this.LLabel_GroupName.TabIndex = 23;
            this.LLabel_GroupName.TabStop = true;
            this.LLabel_GroupName.Text = "LLabel_GroupName";
            this.LLabel_GroupName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabel_GroupName_LinkClicked);
            // 
            // Label_AccountName
            // 
            this.Label_AccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_AccountName.ForeColor = System.Drawing.Color.White;
            this.Label_AccountName.Location = new System.Drawing.Point(31, 0);
            this.Label_AccountName.Name = "Label_AccountName";
            this.Label_AccountName.Size = new System.Drawing.Size(249, 17);
            this.Label_AccountName.TabIndex = 17;
            this.Label_AccountName.Text = "Label_AccountName";
            this.Label_AccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Image_GroupIcon
            // 
            this.Image_GroupIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image_GroupIcon.Image = global::Accounts_Holder.Properties.Resources.noteboook;
            this.Image_GroupIcon.Location = new System.Drawing.Point(0, 0);
            this.Image_GroupIcon.Name = "Image_GroupIcon";
            this.Image_GroupIcon.Size = new System.Drawing.Size(31, 31);
            this.Image_GroupIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_GroupIcon.TabIndex = 16;
            this.Image_GroupIcon.TabStop = false;
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsMenu.AutoSize = false;
            this.ToolsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.ToolsMenu.CanOverflow = false;
            this.ToolsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolsMenu.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMButtonEdit,
            this.TSMButtonDelete});
            this.ToolsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ToolsMenu.Location = new System.Drawing.Point(256, 27);
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(25, 70);
            this.ToolsMenu.TabIndex = 18;
            // 
            // TSMButtonEdit
            // 
            this.TSMButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonEdit.Image = global::Accounts_Holder.Properties.Resources.edit;
            this.TSMButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonEdit.Name = "TSMButtonEdit";
            this.TSMButtonEdit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TSMButtonEdit.Size = new System.Drawing.Size(23, 20);
            this.TSMButtonEdit.Text = "Редактировать данные...";
            this.TSMButtonEdit.Click += new System.EventHandler(this.TSMButtonEdit_Click);
            // 
            // TSMButtonDelete
            // 
            this.TSMButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonDelete.Image = global::Accounts_Holder.Properties.Resources.delete;
            this.TSMButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonDelete.Name = "TSMButtonDelete";
            this.TSMButtonDelete.Size = new System.Drawing.Size(23, 20);
            this.TSMButtonDelete.Text = "Удалить данные";
            this.TSMButtonDelete.Click += new System.EventHandler(this.TSMButtonDelete_Click);
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.Label_Login.Location = new System.Drawing.Point(70, 35);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(38, 15);
            this.Label_Login.TabIndex = 19;
            this.Label_Login.Text = "Login";
            // 
            // Text_Password
            // 
            this.Text_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Text_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Password.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Text_Password.Location = new System.Drawing.Point(73, 53);
            this.Text_Password.MaxLength = 20;
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.ReadOnly = true;
            this.Text_Password.Size = new System.Drawing.Size(180, 16);
            this.Text_Password.TabIndex = 20;
            this.Text_Password.Text = "password";
            this.Text_Password.UseSystemPasswordChar = true;
            // 
            // LLabelShowOrHidePassword
            // 
            this.LLabelShowOrHidePassword.AutoSize = true;
            this.LLabelShowOrHidePassword.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLabelShowOrHidePassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.LLabelShowOrHidePassword.Location = new System.Drawing.Point(88, 78);
            this.LLabelShowOrHidePassword.Name = "LLabelShowOrHidePassword";
            this.LLabelShowOrHidePassword.Size = new System.Drawing.Size(88, 12);
            this.LLabelShowOrHidePassword.TabIndex = 22;
            this.LLabelShowOrHidePassword.TabStop = true;
            this.LLabelShowOrHidePassword.Text = "Показать пароль";
            this.LLabelShowOrHidePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelShowOrHidePassword_LinkClicked);
            // 
            // ImageShowOrHidePassword
            // 
            this.ImageShowOrHidePassword.Image = global::Accounts_Holder.Properties.Resources.show;
            this.ImageShowOrHidePassword.Location = new System.Drawing.Point(68, 75);
            this.ImageShowOrHidePassword.Name = "ImageShowOrHidePassword";
            this.ImageShowOrHidePassword.Size = new System.Drawing.Size(17, 17);
            this.ImageShowOrHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageShowOrHidePassword.TabIndex = 21;
            this.ImageShowOrHidePassword.TabStop = false;
            // 
            // Image_AccountIcon
            // 
            this.Image_AccountIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image_AccountIcon.Image = global::Accounts_Holder.Properties.Resources.user;
            this.Image_AccountIcon.Location = new System.Drawing.Point(0, 31);
            this.Image_AccountIcon.Name = "Image_AccountIcon";
            this.Image_AccountIcon.Size = new System.Drawing.Size(64, 64);
            this.Image_AccountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_AccountIcon.TabIndex = 17;
            this.Image_AccountIcon.TabStop = false;
            // 
            // WidgetAccountTile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.LLabelShowOrHidePassword);
            this.Controls.Add(this.ImageShowOrHidePassword);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.ToolsMenu);
            this.Controls.Add(this.Image_AccountIcon);
            this.Controls.Add(this.Panel_Top);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WidgetAccountTile";
            this.Size = new System.Drawing.Size(280, 95);
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_GroupIcon)).EndInit();
            this.ToolsMenu.ResumeLayout(false);
            this.ToolsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowOrHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_AccountIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Label Label_AccountName;
        private System.Windows.Forms.PictureBox Image_GroupIcon;
        private System.Windows.Forms.PictureBox Image_AccountIcon;
        private System.Windows.Forms.ToolStrip ToolsMenu;
        private System.Windows.Forms.ToolStripButton TSMButtonEdit;
        private System.Windows.Forms.ToolStripButton TSMButtonDelete;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.LinkLabel LLabelShowOrHidePassword;
        private System.Windows.Forms.PictureBox ImageShowOrHidePassword;
        private System.Windows.Forms.LinkLabel LLabel_GroupName;
        protected System.Windows.Forms.TextBox Text_Password;
    }
}
