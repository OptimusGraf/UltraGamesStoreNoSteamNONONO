using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
   static internal class Helper
    {
        static public byte[] FromImageToByteArray(this Image image)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                image.Save(mStream, image.RawFormat);
                return mStream.ToArray();
            }
        }
    }
}
