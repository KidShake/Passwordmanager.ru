using System.Drawing;
using System.Windows.Forms;

namespace Accounts_Holder.View.Widgets
{
    public partial class WigetImageSelector : UserControl
    {
        public WigetImageSelector()
        {
            InitializeComponent();
        }

        public Image SelectedImage
        {
            get => RButtonFileSource.Checked ? ImageIcon.Image : null;
            set
            {
                ImageIcon.Image = value;
                RButtonFileSource.Checked = true;
            }
        }

        private void LLabelBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "PNG Files|*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}