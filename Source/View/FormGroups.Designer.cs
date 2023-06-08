namespace Accounts_Holder.View
{
    partial class FormGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.ToolsMenu = new System.Windows.Forms.ToolStrip();
            this.TSLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.TSMButtonAddRow = new System.Windows.Forms.ToolStripButton();
            this.TSMButtonEditRow = new System.Windows.Forms.ToolStripButton();
            this.TSMButtonDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.DataGrid_Dictionary = new System.Windows.Forms.DataGridView();
            this.COLUMN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.COLUMN_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_UseUrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLUMN_Url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ToolsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.BackColor = System.Drawing.Color.White;
            this.ToolsMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLabelTitle,
            this.TSMButtonAddRow,
            this.TSMButtonEditRow,
            this.TSMButtonDeleteRow});
            this.ToolsMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(634, 25);
            this.ToolsMenu.TabIndex = 23;
            // 
            // TSLabelTitle
            // 
            this.TSLabelTitle.Name = "TSLabelTitle";
            this.TSLabelTitle.Size = new System.Drawing.Size(178, 22);
            this.TSLabelTitle.Text = "Меню управления записями:";
            // 
            // TSMButtonAddRow
            // 
            this.TSMButtonAddRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonAddRow.Image = global::Accounts_Holder.Properties.Resources.add;
            this.TSMButtonAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonAddRow.Name = "TSMButtonAddRow";
            this.TSMButtonAddRow.Size = new System.Drawing.Size(23, 22);
            this.TSMButtonAddRow.Text = "Добавить новую запись...";
            this.TSMButtonAddRow.Click += new System.EventHandler(this.TSMButtonAddRow_Click);
            // 
            // TSMButtonEditRow
            // 
            this.TSMButtonEditRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonEditRow.Image = global::Accounts_Holder.Properties.Resources.edit;
            this.TSMButtonEditRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonEditRow.Name = "TSMButtonEditRow";
            this.TSMButtonEditRow.Size = new System.Drawing.Size(23, 22);
            this.TSMButtonEditRow.Text = "Редактировать выбранную запись";
            this.TSMButtonEditRow.Click += new System.EventHandler(this.TSMButtonEditRow_Click);
            // 
            // TSMButtonDeleteRow
            // 
            this.TSMButtonDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMButtonDeleteRow.Image = global::Accounts_Holder.Properties.Resources.delete;
            this.TSMButtonDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMButtonDeleteRow.Name = "TSMButtonDeleteRow";
            this.TSMButtonDeleteRow.Size = new System.Drawing.Size(23, 22);
            this.TSMButtonDeleteRow.Text = "Удалить выбранную запись";
            this.TSMButtonDeleteRow.Click += new System.EventHandler(this.TSMButtonDeleteRow_Click);
            // 
            // DataGrid_Dictionary
            // 
            this.DataGrid_Dictionary.AllowUserToAddRows = false;
            this.DataGrid_Dictionary.AllowUserToDeleteRows = false;
            this.DataGrid_Dictionary.AllowUserToResizeRows = false;
            this.DataGrid_Dictionary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Dictionary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_Dictionary.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Dictionary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid_Dictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Dictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_ID,
            this.COLUMN_Icon,
            this.COLUMN_Name,
            this.COLUMN_UseUrl,
            this.COLUMN_Url});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Dictionary.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Dictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Dictionary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid_Dictionary.GridColor = System.Drawing.Color.White;
            this.DataGrid_Dictionary.Location = new System.Drawing.Point(0, 25);
            this.DataGrid_Dictionary.MultiSelect = false;
            this.DataGrid_Dictionary.Name = "DataGrid_Dictionary";
            this.DataGrid_Dictionary.RowHeadersVisible = false;
            this.DataGrid_Dictionary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Dictionary.Size = new System.Drawing.Size(634, 286);
            this.DataGrid_Dictionary.TabIndex = 24;
            // 
            // COLUMN_ID
            // 
            this.COLUMN_ID.HeaderText = "ID";
            this.COLUMN_ID.Name = "COLUMN_ID";
            this.COLUMN_ID.Visible = false;
            // 
            // COLUMN_Icon
            // 
            this.COLUMN_Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.COLUMN_Icon.HeaderText = "";
            this.COLUMN_Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.COLUMN_Icon.Name = "COLUMN_Icon";
            this.COLUMN_Icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.COLUMN_Icon.Width = 30;
            // 
            // COLUMN_Name
            // 
            this.COLUMN_Name.HeaderText = "Наименование группы";
            this.COLUMN_Name.Name = "COLUMN_Name";
            // 
            // COLUMN_UseUrl
            // 
            this.COLUMN_UseUrl.HeaderText = "";
            this.COLUMN_UseUrl.Name = "COLUMN_UseUrl";
            this.COLUMN_UseUrl.Visible = false;
            // 
            // COLUMN_Url
            // 
            this.COLUMN_Url.HeaderText = "Icon Url";
            this.COLUMN_Url.Name = "COLUMN_Url";
            this.COLUMN_Url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLUMN_Url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormGroups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.DataGrid_Dictionary);
            this.Controls.Add(this.ToolsMenu);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 250);
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник групп аккаунтов";
            this.ToolsMenu.ResumeLayout(false);
            this.ToolsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dictionary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolsMenu;
        private System.Windows.Forms.ToolStripLabel TSLabelTitle;
        private System.Windows.Forms.ToolStripButton TSMButtonAddRow;
        private System.Windows.Forms.ToolStripButton TSMButtonEditRow;
        private System.Windows.Forms.ToolStripButton TSMButtonDeleteRow;
        private System.Windows.Forms.DataGridView DataGrid_Dictionary;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_ID;
        private System.Windows.Forms.DataGridViewImageColumn COLUMN_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLUMN_UseUrl;
        private System.Windows.Forms.DataGridViewLinkColumn COLUMN_Url;
    }
}