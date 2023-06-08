using System.Drawing;
using System.Windows.Forms;

namespace Accounts_Holder.View
{
    public partial class FormGroupData : Form
    {
        // Constructor
        public FormGroupData()
        {
            InitializeComponent();
        }


        public string GroupName
        {
            get => TextGroupName.Text.Trim();
            set { TextGroupName.Text = value; }
        }
        public bool UseUrlSource
            => WIS_IconSelector.Mode == Widgets.WidgetImageSelector.SelectionMode.Url;
        public string UrlSource
        {
            get => WIS_IconSelector.SelectedImageUrl;
            set { WIS_IconSelector.SelectedImageUrl = value; }
        }
        public Image ImageSource
        {
            get => WIS_IconSelector.SelectedImage;
            set { WIS_IconSelector.SelectedImage = value; }
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void LLabelOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Проверки ввода
            if (string.IsNullOrWhiteSpace(GroupName))
            {
                MessageBox.Show("Введите наименование группы аккаунтов!", Application.ProductName,
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