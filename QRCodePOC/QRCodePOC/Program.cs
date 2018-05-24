using System;

namespace QRCodePOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToRead = @"path\QrCode.png";
            var pathToSave = @"path\NewQrCode.JPG";
            var textToEncode = "https://medium.com/everything-for-developers";

            var read = new Read();

            var valueDecoded = read.Execute(pathToRead);

            var generate = new Generate();

            var qrCode = generate.Execute(textToEncode);

            qrCode.Save(pathToSave);

            Console.ReadKey();
        }
    }
}
