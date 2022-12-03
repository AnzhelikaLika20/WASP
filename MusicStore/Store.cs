using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal class Store
    {
        string storeName;
        string adress;
        List<Audio> audios = new List<Audio>();
        List<DVD> dvds = new List<DVD>();
        public List<Audio> Audios { get { return audios; } set { audios = value; } }
        public List<DVD> Dvds { get { return dvds; } set { dvds = value; } }
        public Store(string storeName, string adress)
        {
            this.storeName = storeName;
            this.adress = adress;
        }
        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < audios.Count; i++)
                s += audios[i] + "\n";
            for (int i = 0; i < dvds.Count; i++)
                s += dvds[i] + "\n";
            return s;
        }
    }
}
