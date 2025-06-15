using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainHub.Properties;

namespace TrainHub
{
    public class QrCode
    {
        public static Bitmap GetCode(string memberID)
        {
            using QRCodeGenerator qrGenerator = new QRCodeGenerator();
            using QRCodeData qrData = qrGenerator.CreateQrCode(memberID, QRCodeGenerator.ECCLevel.Q);
            using QRCode qrCode = new QRCode(qrData);

            return qrCode.GetGraphic(
                20, 
                Color.Black, 
                Color.White,
                true
                );
        }
    }
}
