
namespace UltraGamesStoreNoSteamNONONO
{
    public class MyPictureBox:PictureBox
    {
        byte[] image;
        public  new byte[] Image { get => image; set { image = value; base.Image = image.FromByteArrayToImage(); } }

        public bool SetImageFromDialog()
        {
            byte[] newimage = Helper.GetPictureFromDialog();
            if(newimage == null) 
            {
                return false;
            }

            Image = newimage;
            return true;
        }
    
    }
}
