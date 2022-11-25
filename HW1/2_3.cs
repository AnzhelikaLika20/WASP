namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short m = short.Parse(Console.ReadLine());
            short k = short.Parse(Console.ReadLine());
            short l = short.Parse(Console.ReadLine());
            long x = 0;
            x += l;
            x = x << 16;
            x += k;
            x = x << 16;
            x += m;
            x = x << 16;
            x += n;
            Console.WriteLine(x);
        }
    }
}