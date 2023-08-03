using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class UserInfo
    {

        string userName;
        public string UserName => userName;

        int age;
        public int Age => age;

        int powerOfPC;
        public int PowerOfPC { get => powerOfPC;  }

        byte[] image;
        public byte[] Image { get => image;  }

        public UserInfo(string name, int age, int powerOfPC, byte[] image )
        {
            this.userName = name;
            this.age = age;
            this.powerOfPC = powerOfPC;
            this.image = image;
        }
        public UserInfo( int age, int powerOfPC, byte[] image)
        {
            this.age = age;
            this.powerOfPC = powerOfPC;
            this.image = image;
        }

    }
}
