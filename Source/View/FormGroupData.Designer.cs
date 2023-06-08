namespace Accounts_Holder.View
{
    partial class FormGroupData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupData));
            this.LLabelCancel = new System.Windows.Forms.LinkLabel();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.LLabelOK = new System.Windows.Forms.LinkLabel();
            this.ImageOK = new System.Windows.Forms.PictureBox();
            this.TextGroupName = new System.Windows.Forms.TextBox();
            this.LabelGroupName = new System.Windows.Forms.Label();
            this.WIS_IconSelector = new Accounts_Holder.View.Widgets.WidgetImageSelector();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).BeginInit();
            this.SuspendLayout();
            // 
            // LLabelCancel
            // 
            this.LLabelCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelCancel.AutoSize = true;
            this.LLabelCancel.Location = new System.Drawing.Point(307, 95);
            this.LLabelCancel.Name = "LLabelCancel";
            this.LLabelCancel.Size = new System.Drawing.Size(68, 15);
            this.LLabelCancel.TabIndex = 18;
            this.LLabelCancel.TabStop = true;
            this.LLabelCancel.Text = "Отменить";
            this.LLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelCancel_LinkClicked);
            // 
            // ImageCancel
            // 
            this.ImageCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCancel.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageCancel.Location = new System.Drawing.Point(284, 93);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(20, 20);
            this.ImageCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCancel.TabIndex = 17;
            this.ImageCancel.TabStop = false;
            // 
            // LLabelOK
            // 
            this.LLabelOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelOK.AutoSize = true;
            this.LLabelOK.Location = new System.Drawing.Point(307, 60);
            this.LLabelOK.Name = "LLabelOK";
            this.LLabelOK.Size = new System.Drawing.Size(76, 15);
            this.LLabelOK.TabIndex = 16;
            this.LLabelOK.TabStop = true;
            this.LLabelOK.Text = "Применить";
            this.LLabelOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelOK_LinkClicked);
            // 
            // ImageOK
            // 
            this.ImageOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageOK.Image = global::Accounts_Holder.Properties.Resources.ok;
            this.ImageOK.Location = new System.Drawing.Point(284, 58);
            this.ImageOK.Name = "ImageOK";
            this.ImageOK.Size = new System.Drawing.Size(20, 20);
            this.ImageOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOK.TabIndex = 15;
            this.ImageOK.TabStop = false;
            // 
            // TextGroupName
            // 
            this.TextGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextGroupName.BackColor = System.Drawing.Color.White;
            this.TextGroupName.Font = new System.Drawing.Font("Cambria", 10F);
            this.TextGroupName.Location = new System.Drawing.Point(177, 12);
            this.TextGroupName.MaxLength = 50;
            this.TextGroupName.Name = "TextGroupName";
            this.TextGroupName.Size = new System.Drawing.Size(225, 23);
            this.TextGroupName.TabIndex = 21;
            // 
            // LabelGroupName
            // 
            this.LabelGroupName.AutoSize = true;
            this.LabelGroupName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelGroupName.ForeColor = System.Drawing.Color.Black;
            this.LabelGroupName.Location = new System.Drawing.Point(16, 15);
            this.LabelGroupName.Name = "LabelGroupName";
            this.LabelGroupName.Size = new System.Drawing.Size(155, 16);
            this.LabelGroupName.TabIndex = 20;
            this.LabelGroupName.Text = "Наименование группы:";
            // 
            // WIS_IconSelector
            // 
            this.WIS_IconSelector.BackColor = System.Drawing.Color.White;
            this.WIS_IconSelector.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WIS_IconSelector.Location = new System.Drawing.Point(19, 41);
            this.WIS_IconSelector.Name = "WIS_IconSelector";
            this.WIS_IconSelector.SelectedImage = null;
            this.WIS_IconSelector.SelectedImageUrl = "";
            this.WIS_IconSelector.Size = new System.Drawing.Size(249, 90);
            this.WIS_IconSelector.TabIndex = 22;
            // 
            // FormGroupData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 141);
            this.Controls.Add(this.WIS_IconSelector);
            this.Controls.Add(this.TextGroupName);
            this.Controls.Add(this.LabelGroupName);
            this.Controls.Add(this.LLabelCancel);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.LLabelOK);
            this.Controls.Add(this.ImageOK);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 180);
            this.Name = "FormGroupData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные группы аккаунтов";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LLabelCancel;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.LinkLabel LLabelOK;
        private System.Windows.Forms.PictureBox ImageOK;
        private System.Windows.Forms.TextBox TextGroupName;
        private System.Windows.Forms.Label LabelGroupName;
        private Widgets.WidgetImageSelector WIS_IconSelector;
    }
}