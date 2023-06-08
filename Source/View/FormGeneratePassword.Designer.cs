namespace Accounts_Holder.View
{
    partial class FormGeneratePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneratePassword));
            this.Label_Title = new System.Windows.Forms.Label();
            this.LLabelCancel = new System.Windows.Forms.LinkLabel();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.LLabelOK = new System.Windows.Forms.LinkLabel();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.NumericSelector_Length = new System.Windows.Forms.NumericUpDown();
            this.Label_PasswordLength = new System.Windows.Forms.Label();
            this.LLabelGenerate = new System.Windows.Forms.LinkLabel();
            this.ImageGenerate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSelector_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Title.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(0, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(524, 49);
            this.Label_Title.TabIndex = 33;
            this.Label_Title.Text = "Новый пароль:";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LLabelCancel
            // 
            this.LLabelCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelCancel.AutoSize = true;
            this.LLabelCancel.Location = new System.Drawing.Point(445, 177);
            this.LLabelCancel.Name = "LLabelCancel";
            this.LLabelCancel.Size = new System.Drawing.Size(68, 15);
            this.LLabelCancel.TabIndex = 32;
            this.LLabelCancel.TabStop = true;
            this.LLabelCancel.Text = "Отменить";
            this.LLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCancel_LinkClicked);
            // 
            // ImageCancel
            // 
            this.ImageCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCancel.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageCancel.Location = new System.Drawing.Point(422, 175);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(20, 20);
            this.ImageCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCancel.TabIndex = 31;
            this.ImageCancel.TabStop = false;
            // 
            // LLabelOK
            // 
            this.LLabelOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelOK.AutoSize = true;
            this.LLabelOK.Location = new System.Drawing.Point(36, 177);
            this.LLabelOK.Name = "LLabelOK";
            this.LLabelOK.Size = new System.Drawing.Size(76, 15);
            this.LLabelOK.TabIndex = 30;
            this.LLabelOK.TabStop = true;
            this.LLabelOK.Text = "Применить";
            this.LLabelOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelOK_LinkClicked);
            // 
            // ImageOK
            // 
            this.ImageOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageOK.Image = global::Accounts_Holder.Properties.Resources.ok;
            this.ImageOK.Location = new System.Drawing.Point(13, 175);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(20, 20);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOK.TabIndex = 29;
            this.ImageOK.TabStop = false;
            // 
            // Label_Password
            // 
            this.Label_Password.BackColor = System.Drawing.Color.White;
            this.Label_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Password.Font = new System.Drawing.Font("Cambria", 20F);
            this.Label_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label_Password.Location = new System.Drawing.Point(0, 49);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(524, 67);
            this.Label_Password.TabIndex = 34;
            this.Label_Password.Text = "_passwordNew1!";
            this.Label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericSelector_Length
            // 
            this.NumericSelector_Length.Location = new System.Drawing.Point(63, 126);
            this.NumericSelector_Length.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericSelector_Length.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericSelector_Length.Name = "NumericSelector_Length";
            this.NumericSelector_Length.Size = new System.Drawing.Size(45, 23);
            this.NumericSelector_Length.TabIndex = 35;
            this.NumericSelector_Length.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Label_PasswordLength
            // 
            this.Label_PasswordLength.AutoSize = true;
            this.Label_PasswordLength.Location = new System.Drawing.Point(12, 130);
            this.Label_PasswordLength.Name = "Label_PasswordLength";
            this.Label_PasswordLength.Size = new System.Drawing.Size(48, 15);
            this.Label_PasswordLength.TabIndex = 36;
            this.Label_PasswordLength.Text = "Длина:";
            // 
            // LLabelGenerate
            // 
            this.LLabelGenerate.AutoSize = true;
            this.LLabelGenerate.Location = new System.Drawing.Point(137, 129);
            this.LLabelGenerate.Name = "LLabelGenerate";
            this.LLabelGenerate.Size = new System.Drawing.Size(96, 15);
            this.LLabelGenerate.TabIndex = 38;
            this.LLabelGenerate.TabStop = true;
            this.LLabelGenerate.Text = "Сгенерировать";
            this.LLabelGenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelGenerate_LinkClicked);
            // 
            // ImageGenerate
            // 
            this.ImageGenerate.Image = global::Accounts_Holder.Properties.Resources.configure;
            this.ImageGenerate.Location = new System.Drawing.Point(114, 127);
            this.ImageGenerate.Name = "ImageGenerate";
            this.ImageGenerate.Size = new System.Drawing.Size(20, 20);
            this.ImageGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageGenerate.TabIndex = 37;
            this.ImageGenerate.TabStop = false;
            // 
            // FormGeneratePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 201);
            this.Controls.Add(this.LLabelGenerate);
            this.Controls.Add(this.ImageGenerate);
            this.Controls.Add(this.Label_PasswordLength);
            this.Controls.Add(this.NumericSelector_Length);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.LLabelCancel);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.LLabelOK);
            this.Controls.Add(this.ImageOK);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGeneratePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Генерация надежного пароля";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSelector_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.LinkLabel LLabelCancel;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.LinkLabel LLabelOK;
        private System.Windows.Forms.PictureBox ImageOK;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.NumericUpDown NumericSelector_Length;
        private System.Windows.Forms.Label Label_PasswordLength;
        private System.Windows.Forms.LinkLabel LLabelGenerate;
        private System.Windows.Forms.PictureBox ImageGenerate;
    }
}