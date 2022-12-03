using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal class Disk : IStoreItem
    {
        string name;
        string genre;
        int burnCount = 0;
        public string Name { get { return name; } set { name = value; } }
        public string Genre { get { return genre; } set { name = value; } }
        public int BurnCount { get { return burnCount; } set { burnCount = value; } }
        public virtual int DiskSize { get; set; }
        public double Price { get; set; }
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual void Burn(params string[] values) { }
    }
}
