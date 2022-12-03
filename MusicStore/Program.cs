namespace MusicStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Guitar", "Moscow");
            store.Dvds += new DVD("Silver", "Village Roadshow Pictures", 120, "Matrix", "action");
            store.Dvds += new DVD("Jack", "20th century fox", 180, "Rainbow", "comedy");
            store.Audios += new Audio("Beethoven", "NoName", 70, "Masterpiece", "music");
            store.Audios += new Audio("Bah", "UnKnown", 90, "Sonata", "classic");
            Console.WriteLine(store);
            store.Audios[0].Burn("Imagine Dragons", "No", "3", "modern", "Believe");
            for(int i = 0; i < store.Dvds.Count; i++)
                Console.WriteLine($"{store.Dvds[i].Name} --> {store.Dvds[i].DiskSize}");
            for(int i = 0; i < store.Audios.Count; i++)
                Console.WriteLine($"{store.Audios[i].Name} --> {store.Audios[i].DiskSize}");
        }
    }
}