using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    static public class Helper
    {
        static public byte[] FromImageToByteArray(this Image image)
        {
            byte[] byteImage;
            using (MemoryStream mStream = new MemoryStream())
            {
                image?.Save(mStream, image.RawFormat);
                byteImage = mStream.ToArray();
            }
            return byteImage;
        }

        static public Image FromByteArrayToImage(this byte[] bytes)
        {
            Image image = null;
            if (bytes != null && bytes.Length != 0)
            {
                using (MemoryStream mStream = new MemoryStream(bytes))
                {
                    image = Image.FromStream(mStream);
                    
                }
            }
            
            return image;

        }
        public static byte[] GetPictureFromDialog( )
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            byte[] image = null;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                image = File.ReadAllBytes(fileDialog.FileName);
            }
            return image;
        }
    }
}





