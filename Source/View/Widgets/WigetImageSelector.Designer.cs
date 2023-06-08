namespace Accounts_Holder.View.Widgets
{
    partial class WigetImageSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WigetImageSelector));
            this.GBoxFrame = new System.Windows.Forms.GroupBox();
            this.RButtonUrlSource = new System.Windows.Forms.RadioButton();
            this.RButtonFileSource = new System.Windows.Forms.RadioButton();
            this.LLabelBrowse = new System.Windows.Forms.LinkLabel();
            this.ImageBrowse = new System.Windows.Forms.PictureBox();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.ImageUrl = new System.Windows.Forms.PictureBox();
            this.ImageIcon = new System.Windows.Forms.PictureBox();
            this.RButtonNoSource = new System.Windows.Forms.RadioButton();
            this.GBoxFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // GBoxFrame
            // 
            this.GBoxFrame.Controls.Add(this.RButtonNoSource);
            this.GBoxFrame.Controls.Add(this.ImageIcon);
            this.GBoxFrame.Controls.Add(this.ImageUrl);
            this.GBoxFrame.Controls.Add(this.LLabelBrowse);
            this.GBoxFrame.Controls.Add(this.ImageBrowse);
            this.GBoxFrame.Controls.Add(this.TextLogin);
            this.GBoxFrame.Controls.Add(this.RButtonFileSource);
            this.GBoxFrame.Controls.Add(this.RButtonUrlSource);
            this.GBoxFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBoxFrame.Location = new System.Drawing.Point(0, 0);
            this.GBoxFrame.Name = "GBoxFrame";
            this.GBoxFrame.Size = new System.Drawing.Size(249, 90);
            this.GBoxFrame.TabIndex = 0;
            this.GBoxFrame.TabStop = false;
            // 
            // RButtonUrlSource
            // 
            this.RButtonUrlSource.AutoSize = true;
            this.RButtonUrlSource.Location = new System.Drawing.Point(7, 15);
            this.RButtonUrlSource.Name = "RButtonUrlSource";
            this.RButtonUrlSource.Size = new System.Drawing.Size(45, 19);
            this.RButtonUrlSource.TabIndex = 0;
            this.RButtonUrlSource.Text = "Url:";
            this.RButtonUrlSource.UseVisualStyleBackColor = true;
            // 
            // RButtonFileSource
            // 
            this.RButtonFileSource.AutoSize = true;
            this.RButtonFileSource.Location = new System.Drawing.Point(7, 42);
            this.RButtonFileSource.Name = "RButtonFileSource";
            this.RButtonFileSource.Size = new System.Drawing.Size(49, 19);
            this.RButtonFileSource.TabIndex = 1;
            this.RButtonFileSource.Text = "File:";
            this.RButtonFileSource.UseVisualStyleBackColor = true;
            // 
            // LLabelBrowse
            // 
            this.LLabelBrowse.AutoSize = true;
            this.LLabelBrowse.Location = new System.Drawing.Point(82, 43);
            this.LLabelBrowse.Name = "LLabelBrowse";
            this.LLabelBrowse.Size = new System.Drawing.Size(68, 15);
            this.LLabelBrowse.TabIndex = 12;
            this.LLabelBrowse.TabStop = true;
            this.LLabelBrowse.Text = "Выбрать...";
            this.LLabelBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelBrowse_LinkClicked);
            // 
            // ImageBrowse
            // 
            this.ImageBrowse.Image = ((System.Drawing.Image)(resources.GetObject("ImageBrowse.Image")));
            this.ImageBrowse.Location = new System.Drawing.Point(59, 41);
            this.ImageBrowse.Name = "ImageBrowse";
            this.ImageBrowse.Size = new System.Drawing.Size(20, 20);
            this.ImageBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBrowse.TabIndex = 11;
            this.ImageBrowse.TabStop = false;
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(59, 12);
            this.TextLogin.MaxLength = 100;
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(158, 23);
            this.TextLogin.TabIndex = 10;
            // 
            // ImageUrl
            // 
            this.ImageUrl.Image = ((System.Drawing.Image)(resources.GetObject("ImageUrl.Image")));
            this.ImageUrl.Location = new System.Drawing.Point(219, 13);
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Size = new System.Drawing.Size(20, 20);
            this.ImageUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageUrl.TabIndex = 13;
            this.ImageUrl.TabStop = false;
            // 
            // ImageIcon
            // 
            this.ImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImageIcon.Image")));
            this.ImageIcon.Location = new System.Drawing.Point(194, 39);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Size = new System.Drawing.Size(45, 45);
            this.ImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageIcon.TabIndex = 14;
            this.ImageIcon.TabStop = false;
            // 
            // RButtonNoSource
            // 
            this.RButtonNoSource.AutoSize = true;
            this.RButtonNoSource.Checked = true;
            this.RButtonNoSource.Location = new System.Drawing.Point(7, 68);
            this.RButtonNoSource.Name = "RButtonNoSource";
            this.RButtonNoSource.Size = new System.Drawing.Size(77, 19);
            this.RButtonNoSource.TabIndex = 15;
            this.RButtonNoSource.TabStop = true;
            this.RButtonNoSource.Text = "No image";
            this.RButtonNoSource.UseVisualStyleBackColor = true;
            // 
            // WigetImageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GBoxFrame);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WigetImageSelector";
            this.Size = new System.Drawing.Size(249, 90);
            this.GBoxFrame.ResumeLayout(false);
            this.GBoxFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxFrame;
        private System.Windows.Forms.RadioButton RButtonFileSource;
        private System.Windows.Forms.RadioButton RButtonUrlSource;
        private System.Windows.Forms.LinkLabel LLabelBrowse;
        private System.Windows.Forms.PictureBox ImageBrowse;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.PictureBox ImageUrl;
        private System.Windows.Forms.RadioButton RButtonNoSource;
        private System.Windows.Forms.PictureBox ImageIcon;
    }
}
