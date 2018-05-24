using MessagingToolkit.QRCode.Codec;
using System.Drawing;

namespace QRCodePOC
{
    public class Generate
    {
     

        public Bitmap Execute(string text)
        {
            var qrCodeEncoder = new QRCodeEncoder();
            //qrCodeEncoder.QRCodeBackgroundColor = Color.White;
            //qrCodeEncoder.QRCodeForegroundColor = Color.Black;
            //qrCodeEncoder.CharacterSet = "UTF-8";
            //qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //qrCodeEncoder.QRCodeScale = 6;
            //qrCodeEncoder.QRCodeVersion = 0;
            //qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;

            var imageQrCode = qrCodeEncoder.Encode(text);

            return imageQrCode;
        }
    }
}
