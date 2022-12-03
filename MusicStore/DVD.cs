using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal class DVD : Disk
    {
        string? producer;
        string? filmCompany;
        int minutesCount;
        public DVD (string producer, string filmCompany, int minutesCount, 
            string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public override int DiskSize { get => (minutesCount / 64) * 2; }
        public override void Burn(params string[] values)
        {
            BurnCount++;
            producer = values[0];
            filmCompany = values[1];
            minutesCount = int.Parse(values[2]);
            Name = values[3];
            Genre = values[4];
        }
        public static List<DVD> operator +(List<DVD> list, DVD audio)
        {
            list.Add(audio);
            return list;
        }
        public static List<DVD> operator -(List<DVD> list, DVD audio)
        {
            list.Remove(audio);
            return list;
        }
        public override string ToString()
        {
            return $"{Name} {Genre} {producer} {filmCompany} {minutesCount} {BurnCount}";
        }
    }
}
