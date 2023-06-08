using System.Drawing;
using System.Windows.Forms;

namespace Accounts_Holder.View.Widgets
{
    public partial class WidgetImageSelector : UserControl
    {
        public enum SelectionMode 
        {
            None,
            Image,
            Url
        }


        // Constructor
        public WidgetImageSelector()
        {
            InitializeComponent();

            RButtonNoSource.Checked = true;
        }


        public SelectionMode Mode
        {
            get
            {
                if (RButtonNoSource.Checked) return SelectionMode.None;
                if (RButtonFileSource.Checked) return SelectionMode.Image;
                if (RButtonUrlSource.Checked) return SelectionMode.Url;
                return SelectionMode.None;
            }
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
        public string SelectedImageUrl
        {
            get => TextUrl.Text.Trim();
            set
            {
                TextUrl.Text = value;
                RButtonUrlSource.Checked = true;
                // LoadImageFromUrl(value);
            }
        }

        private void LoadImageFromUrl(string __url_)
        {
            Image image = Utils.Conversion.ImageConverter.FromUrl(__url_);

            if (image != null) ImageIcon.Image = image;
        }


        // ------- GUI Elements Commands -------------------------------------------------------------------

        private void LLabelBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (RButtonFileSource.Checked)
            {
                Image image = Sys.SelectPNGFromFile();
                if (image != null)
                    ImageIcon.Image = image;
            }
            else
                MessageBox.Show("Выберите сначала источник загрузки изображения: из файла!",
                    Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TextUrl_Leave(object sender, System.EventArgs e)
        {
            if (RButtonUrlSource.Checked)
                LoadImageFromUrl(SelectedImageUrl);
        }

        private void RButtonUrlSource_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RButtonUrlSource.Checked && !string.IsNullOrWhiteSpace(SelectedImageUrl))
                LoadImageFromUrl(SelectedImageUrl);
        }
    }
}