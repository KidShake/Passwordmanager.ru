namespace Accounts_Holder.View
{
    partial class FormMoveToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoveToGroup));
            this.TSComboBoxGroups = new System.Windows.Forms.ComboBox();
            this.LabelGroupName = new System.Windows.Forms.Label();
            this.LLabelCancel = new System.Windows.Forms.LinkLabel();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.LLabelOK = new System.Windows.Forms.LinkLabel();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.Image_MainIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_MainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TSComboBoxGroups
            // 
            this.TSComboBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSComboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSComboBoxGroups.FormattingEnabled = true;
            this.TSComboBoxGroups.Location = new System.Drawing.Point(213, 19);
            this.TSComboBoxGroups.Name = "TSComboBoxGroups";
            this.TSComboBoxGroups.Size = new System.Drawing.Size(436, 23);
            this.TSComboBoxGroups.TabIndex = 38;
            // 
            // LabelGroupName
            // 
            this.LabelGroupName.AutoSize = true;
            this.LabelGroupName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelGroupName.ForeColor = System.Drawing.Color.Black;
            this.LabelGroupName.Location = new System.Drawing.Point(56, 22);
            this.LabelGroupName.Name = "LabelGroupName";
            this.LabelGroupName.Size = new System.Drawing.Size(151, 16);
            this.LabelGroupName.TabIndex = 37;
            this.LabelGroupName.Text = "Переместить в группу:";
            // 
            // LLabelCancel
            // 
            this.LLabelCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelCancel.AutoSize = true;
            this.LLabelCancel.Location = new System.Drawing.Point(341, 59);
            this.LLabelCancel.Name = "LLabelCancel";
            this.LLabelCancel.Size = new System.Drawing.Size(68, 15);
            this.LLabelCancel.TabIndex = 36;
            this.LLabelCancel.TabStop = true;
            this.LLabelCancel.Text = "Отменить";
            this.LLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCancel_LinkClicked);
            // 
            // ImageCancel
            // 
            this.ImageCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageCancel.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageCancel.Location = new System.Drawing.Point(318, 57);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(20, 20);
            this.ImageCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCancel.TabIndex = 35;
            this.ImageCancel.TabStop = false;
            // 
            // LLabelOK
            // 
            this.LLabelOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLabelOK.AutoSize = true;
            this.LLabelOK.Location = new System.Drawing.Point(236, 59);
            this.LLabelOK.Name = "LLabelOK";
            this.LLabelOK.Size = new System.Drawing.Size(76, 15);
            this.LLabelOK.TabIndex = 34;
            this.LLabelOK.TabStop = true;
            this.LLabelOK.Text = "Применить";
            this.LLabelOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelOK_LinkClicked);
            // 
            // ImageOK
            // 
            this.ImageOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageOK.Image = global::Accounts_Holder.Properties.Resources.ok;
            this.ImageOK.Location = new System.Drawing.Point(213, 57);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(20, 20);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOK.TabIndex = 33;
            this.ImageOK.TabStop = false;
            // 
            // Image_MainIcon
            // 
            this.Image_MainIcon.Image = ((System.Drawing.Image)(resources.GetObject("Image_MainIcon.Image")));
            this.Image_MainIcon.Location = new System.Drawing.Point(12, 12);
            this.Image_MainIcon.Name = "Image_MainIcon";
            this.Image_MainIcon.Size = new System.Drawing.Size(35, 35);
            this.Image_MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_MainIcon.TabIndex = 39;
            this.Image_MainIcon.TabStop = false;
            // 
            // FormMoveToGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 89);
            this.Controls.Add(this.Image_MainIcon);
            this.Controls.Add(this.TSComboBoxGroups);
            this.Controls.Add(this.LabelGroupName);
            this.Controls.Add(this.LLabelCancel);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.LLabelOK);
            this.Controls.Add(this.ImageOK);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMoveToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переместить в группу...";
            this.Load += new System.EventHandler(this.FormMoveToGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_MainIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TSComboBoxGroups;
        private System.Windows.Forms.Label LabelGroupName;
        private System.Windows.Forms.LinkLabel LLabelCancel;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.LinkLabel LLabelOK;
        private System.Windows.Forms.PictureBox ImageOK;
        private System.Windows.Forms.PictureBox Image_MainIcon;
    }
}