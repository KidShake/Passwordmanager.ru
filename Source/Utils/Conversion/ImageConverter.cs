using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Accounts_Holder.Utils.Conversion
{
    public class ImageConverter
    {
        public static byte[] ImageToBytes(Image __image_)
        {
            MemoryStream ms = new MemoryStream();
            __image_.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image BytesToImage(byte[] __bytes_)
        {
            MemoryStream ms = new MemoryStream(__bytes_, 0, __bytes_.Length);
            ms.Write(__bytes_, 0, __bytes_.Length);
            return new Bitmap(ms);
        }

        public static Image FromUrl(string __url_)
        {
            try
            {
                var request = System.Net.WebRequest.Create(__url_);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                    return Image.FromStream(stream);
            }
            catch { return null; }
        }
    }
}