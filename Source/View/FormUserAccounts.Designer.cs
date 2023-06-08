namespace Accounts_Holder.View
{
    partial class FormUserAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserAccounts));
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.LLabelEditMe = new System.Windows.Forms.LinkLabel();
            this.ImageEditMe = new System.Windows.Forms.PictureBox();
            this.LLabelDeleteMe = new System.Windows.Forms.LinkLabel();
            this.ImageDeleteMe = new System.Windows.Forms.PictureBox();
            this.ImageUserAvatar = new System.Windows.Forms.PictureBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.ToolsMenu = new System.Windows.Forms.ToolStrip();
            this.TSMButtonAddAccount = new System.Windows.Forms.ToolStripButton();
            this.TSMButtonPrintReport = new System.Windows.Forms.ToolStripButton();
            this.TSMButtonGroupsDictionary = new System.Windows.Forms.ToolStripButton();
            this.TSeparator_First = new System.Windows.Forms.ToolStripSeparator();
            this.TSMButtonColorSelection = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMButtonCSWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMButtonCSBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMButtonCSDark = new System.Windows.Forms.ToolStripMenuItem();
            this.TSeparator_Second = new System.Windows.Forms.ToolStripSeparator();
            this.TSComboBoxGroups = new System.Windows.Forms.ToolStripComboBox();
            this.TSMButtonGroupsShowAll = new System.Windows.Forms.ToolStripButton();
            this.FlowPanelData = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeleteMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUserAvatar)).BeginInit();
            this.ToolsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelGeneral.Controls.Add(this.LLabelEditMe);
            this.PanelGeneral.Controls.Add(this.ImageEditMe);
            this.PanelGeneral.Controls.Add(this.LLabelDeleteMe);
            this.PanelGeneral.Controls.Add(this.ImageDeleteMe);
            this.PanelGeneral.Controls.Add(this.ImageUserAvatar);
            this.PanelGeneral.Controls.Add(this.LabelUserName);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(834, 60);
            this.PanelGeneral.TabIndex = 21;
            // 
            // LLabelEditMe
            // 
            this.LLabelEditMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelEditMe.AutoSize = true;
            this.LLabelEditMe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LLabelEditMe.Location = new System.Drawing.Point(462, 35);
            this.LLabelEditMe.Name = "LLabelEditMe";
            this.LLabelEditMe.Size = new System.Drawing.Size(193, 15);
            this.LLabelEditMe.TabIndex = 22;
            this.LLabelEditMe.TabStop = true;
            this.LLabelEditMe.Text = "Редактировать личные данные";
            this.LLabelEditMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelEditMe_LinkClicked);
            // 
            // ImageEditMe
            // 
            this.ImageEditMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageEditMe.Image = global::Accounts_Holder.Properties.Resources.edit;
            this.ImageEditMe.Location = new System.Drawing.Point(439, 33);
            this.ImageEditMe.Name = "ImageEditMe";
            this.ImageEditMe.Size = new System.Drawing.Size(20, 20);
            this.ImageEditMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageEditMe.TabIndex = 21;
            this.ImageEditMe.TabStop = false;
            // 
            // LLabelDeleteMe
            // 
            this.LLabelDeleteMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LLabelDeleteMe.AutoSize = true;
            this.LLabelDeleteMe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LLabelDeleteMe.Location = new System.Drawing.Point(690, 35);
            this.LLabelDeleteMe.Name = "LLabelDeleteMe";
            this.LLabelDeleteMe.Size = new System.Drawing.Size(137, 15);
            this.LLabelDeleteMe.TabIndex = 20;
            this.LLabelDeleteMe.TabStop = true;
            this.LLabelDeleteMe.Text = "Удалить свой аккаунт";
            this.LLabelDeleteMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelDeleteMe_LinkClicked);
            // 
            // ImageDeleteMe
            // 
            this.ImageDeleteMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDeleteMe.Image = global::Accounts_Holder.Properties.Resources.close;
            this.ImageDeleteMe.Location = new System.Drawing.Point(667, 33);
            this.ImageDeleteMe.Name = "ImageDeleteMe";
            this.ImageDeleteMe.Size = new System.Drawing.Size(20, 20);
            this.ImageDeleteMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDeleteMe.TabIndex = 19;
            this.ImageDeleteMe.TabStop = false;
            // 
            // ImageUserAvatar
            // 
            this.ImageUserAvatar.Image = global::Accounts_Holder.Properties.Resources.user;
            this.ImageUserAvatar.Location = new System.Drawing.Point(3, 5);
            this.ImageUserAvatar.Name = "ImageUserAvatar";
            this.ImageUserAvatar.Size = new System.Drawing.Size(50, 50);
            this.ImageUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageUserAvatar.TabIndex = 15;
            this.ImageUserAvatar.TabStop = false;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Cambria", 12F);
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelUserName.Location = new System.Drawing.Point(59, 9);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(149, 19);
            this.LabelUserName.TabIndex = 18;
            this.LabelUserName.Text = "Имя пользователя:";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.BackColor = System.Drawing.Color.White;
            this.ToolsMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMButtonAddAccount,
            this.TSMButtonPrintReport,
            this.TSMButtonGroupsDictionary,
            this.TSeparator_First,
            this.TSMButtonColorSelection,
            this.TSeparator_Second,
            this.TSComboBoxGroups,
            this.TSMButtonGroupsShowAll});
            this.ToolsMenu.Location = new System.Drawing.Point(0, 60);
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(834, 25);
            this.ToolsMenu.TabIndex = 22;
            // 
            // TSMButtonAddAccount
            // 
            this.TSMButtonAddAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonAddAccount.Image = global::Accounts_Holder.Properties.Resources.add;
            this.TSMButtonAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonAddAccount.Name = "TSMButtonAddAccount";
            this.TSMButtonAddAccount.Size = new System.Drawing.Size(23, 22);
            this.TSMButtonAddAccount.Text = "Добавить новый аккаунт...";
            this.TSMButtonAddAccount.Click += new System.EventHandler(this.TSMButtonAddAccount_Click);
            // 
            // TSMButtonPrintReport
            // 
            this.TSMButtonPrintReport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSMButtonPrintReport.Image = global::Accounts_Holder.Properties.Resources.report;
            this.TSMButtonPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonPrintReport.Name = "TSMButtonPrintReport";
            this.TSMButtonPrintReport.Size = new System.Drawing.Size(157, 22);
            this.TSMButtonPrintReport.Text = "Распечатка аккаунтов";
            this.TSMButtonPrintReport.ToolTipText = "Распечатка аккаунтов";
            this.TSMButtonPrintReport.Click += new System.EventHandler(this.TSMButtonPrintReport_Click);
            // 
            // TSMButtonGroupsDictionary
            // 
            this.TSMButtonGroupsDictionary.Image = global::Accounts_Holder.Properties.Resources.groups;
            this.TSMButtonGroupsDictionary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonGroupsDictionary.Name = "TSMButtonGroupsDictionary";
            this.TSMButtonGroupsDictionary.Size = new System.Drawing.Size(200, 22);
            this.TSMButtonGroupsDictionary.Text = "Справочник групп аккаунтов";
            this.TSMButtonGroupsDictionary.Click += new System.EventHandler(this.TSMButtonGroupsDictionary_Click);
            // 
            // TSeparator_First
            // 
            this.TSeparator_First.Name = "TSeparator_First";
            this.TSeparator_First.Size = new System.Drawing.Size(6, 25);
            // 
            // TSMButtonColorSelection
            // 
            this.TSMButtonColorSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonColorSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMButtonCSWhite,
            this.TSMButtonCSBlue,
            this.TSMButtonCSDark});
            this.TSMButtonColorSelection.Image = global::Accounts_Holder.Properties.Resources.colors;
            this.TSMButtonColorSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonColorSelection.Name = "TSMButtonColorSelection";
            this.TSMButtonColorSelection.Size = new System.Drawing.Size(29, 22);
            this.TSMButtonColorSelection.Text = "Выбрать цветовую схему";
            // 
            // TSMButtonCSWhite
            // 
            this.TSMButtonCSWhite.Image = global::Accounts_Holder.Properties.Resources.colors;
            this.TSMButtonCSWhite.Name = "TSMButtonCSWhite";
            this.TSMButtonCSWhite.Size = new System.Drawing.Size(122, 22);
            this.TSMButtonCSWhite.Text = "Белый";
            this.TSMButtonCSWhite.Click += new System.EventHandler(this.TSMButtonCSWhite_Click);
            // 
            // TSMButtonCSBlue
            // 
            this.TSMButtonCSBlue.Image = global::Accounts_Holder.Properties.Resources.colors;
            this.TSMButtonCSBlue.Name = "TSMButtonCSBlue";
            this.TSMButtonCSBlue.Size = new System.Drawing.Size(122, 22);
            this.TSMButtonCSBlue.Text = "Синий";
            this.TSMButtonCSBlue.Click += new System.EventHandler(this.TSMButtonCSBlue_Click);
            // 
            // TSMButtonCSDark
            // 
            this.TSMButtonCSDark.Image = global::Accounts_Holder.Properties.Resources.colors;
            this.TSMButtonCSDark.Name = "TSMButtonCSDark";
            this.TSMButtonCSDark.Size = new System.Drawing.Size(122, 22);
            this.TSMButtonCSDark.Text = "Темный";
            this.TSMButtonCSDark.Click += new System.EventHandler(this.TSMButtonCSDark_Click);
            // 
            // TSeparator_Second
            // 
            this.TSeparator_Second.Name = "TSeparator_Second";
            this.TSeparator_Second.Size = new System.Drawing.Size(6, 25);
            // 
            // TSComboBoxGroups
            // 
            this.TSComboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSComboBoxGroups.Items.AddRange(new object[] {
            "Все",
            "1",
            "2",
            "3",
            "4"});
            this.TSComboBoxGroups.Name = "TSComboBoxGroups";
            this.TSComboBoxGroups.Size = new System.Drawing.Size(155, 25);
            this.TSComboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.TSComboBoxCroups_SelectedIndexChanged);
            // 
            // TSMButtonGroupsShowAll
            // 
            this.TSMButtonGroupsShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMButtonGroupsShowAll.Image = ((System.Drawing.Image)(resources.GetObject("TSMButtonGroupsShowAll.Image")));
            this.TSMButtonGroupsShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonGroupsShowAll.Name = "TSMButtonGroupsShowAll";
            this.TSMButtonGroupsShowAll.Size = new System.Drawing.Size(31, 22);
            this.TSMButtonGroupsShowAll.Text = "Все";
            this.TSMButtonGroupsShowAll.Click += new System.EventHandler(this.TSMButtonGroupsShowAll_Click);
            // 
            // FlowPanelData
            // 
            this.FlowPanelData.AutoScroll = true;
            this.FlowPanelData.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.FlowPanelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.FlowPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelData.Location = new System.Drawing.Point(0, 85);
            this.FlowPanelData.Name = "FlowPanelData";
            this.FlowPanelData.Size = new System.Drawing.Size(834, 476);
            this.FlowPanelData.TabIndex = 23;
            // 
            // FormUserAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.FlowPanelData);
            this.Controls.Add(this.ToolsMenu);
            this.Controls.Add(this.PanelGeneral);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 320);
            this.Name = "FormUserAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подсистема учета аккаунтов пользователя";
            this.Load += new System.EventHandler(this.FormUserAccounts_Load);
            this.PanelGeneral.ResumeLayout(false);
            this.PanelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeleteMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUserAvatar)).EndInit();
            this.ToolsMenu.ResumeLayout(false);
            this.ToolsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.PictureBox ImageUserAvatar;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.ToolStrip ToolsMenu;
        private System.Windows.Forms.ToolStripButton TSMButtonAddAccount;
        private System.Windows.Forms.ToolStripButton TSMButtonPrintReport;
        private System.Windows.Forms.ToolStripButton TSMButtonGroupsDictionary;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelData;
        private System.Windows.Forms.ToolStripSeparator TSeparator_First;
        private System.Windows.Forms.ToolStripDropDownButton TSMButtonColorSelection;
        private System.Windows.Forms.ToolStripMenuItem TSMButtonCSWhite;
        private System.Windows.Forms.ToolStripMenuItem TSMButtonCSBlue;
        private System.Windows.Forms.ToolStripMenuItem TSMButtonCSDark;
        private System.Windows.Forms.ToolStripSeparator TSeparator_Second;
        private System.Windows.Forms.ToolStripComboBox TSComboBoxGroups;
        private System.Windows.Forms.LinkLabel LLabelDeleteMe;
        private System.Windows.Forms.PictureBox ImageDeleteMe;
        private System.Windows.Forms.LinkLabel LLabelEditMe;
        private System.Windows.Forms.PictureBox ImageEditMe;
        private System.Windows.Forms.ToolStripButton TSMButtonGroupsShowAll;
    }
}