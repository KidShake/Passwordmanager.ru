using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Accounts_Holder.View
{
    public partial class FormMoveToGroup : Form
    {
        int _user_id;
        int _group_ID;        

        public FormMoveToGroup(int __user_id_, int __group_ID_)
        {
            InitializeComponent();

            _user_id = __user_id_;
            _group_ID = __group_ID_;
        }


        public int SelectedGroupID =>
            TSComboBoxGroups.SelectedValue == null
                ? 0
                : Convert.ToInt32(TSComboBoxGroups.SelectedValue);



        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void FormMoveToGroup_Load(object sender, EventArgs e)
        {
            TSComboBoxGroups.DataSource = Sys.AppCtrl.GetGroupsTableWithData(_user_id);
            TSComboBoxGroups.ValueMember = "ID";
            TSComboBoxGroups.DisplayMember = "Name";
        }

        private void LLabelOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SelectedGroupID == 0)
            {
                MessageBox.Show("Выберите из списка групппу для перемещения аккаунта!",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SelectedGroupID == _group_ID)
            {
                MessageBox.Show("Аккаунт уже находится в выбранной группе!",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void LLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}