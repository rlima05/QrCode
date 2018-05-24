using MessagingToolkit.QRCode.Codec;
using System.Drawing;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCodePOC
{
    public class Read 
    {
        

        public string Execute(string imagePath)
        {
            var qrCodeDecoder = new QRCodeDecoder();
            var bitmapImage = Image.FromFile(imagePath) as Bitmap;
            var qrCodeImage = new QRCodeBitmapImage(bitmapImage);

            return qrCodeDecoder.Decode(qrCodeImage);
        }
    }
}
