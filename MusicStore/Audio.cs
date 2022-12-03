using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal class Audio : Disk
    {
        string artist;
        string recordingStudio;
        int songsNumber;
        public Audio (string artist, string recordingStudio, int songsNumber, 
            string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public override int DiskSize { get => songsNumber * 8; }
        public override void Burn(params string[] values)
        {
            BurnCount++;
            artist = values[0];
            recordingStudio = values[1];
            songsNumber = int.Parse(values[2]);
            Name = values[3];
            Genre = values[4];
        }
        public static List<Audio> operator +(List<Audio> list, Audio audio)
        {
            list.Add(audio);
            return list;
        }
        public static List<Audio> operator -(List<Audio> list, Audio audio)
        {
            list.Remove(audio);
            return list;
        }
        public override string ToString()
        {
            return $"{Name} {Genre} {artist} {recordingStudio} {songsNumber} {BurnCount}";
        }
    }
}
