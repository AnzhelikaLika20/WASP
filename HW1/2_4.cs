namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] c = new long[4];
            long n = long.Parse(Console.ReadLine());
            c[3] = n >> 48;
            c[2] = (n << 16) >> 48;
            c[1] = (n << 32) >> 48;
            c[0] = (n << 48) >> 48;
            for (int i = 0; i < 4; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}