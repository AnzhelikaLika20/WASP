namespace _2._5
{
    internal class Program
    {
        public static string Bin(double n)
        {
            string s = String.Empty;
            while (n > 0)
            {
                s = (n % 2).ToString() + s;
                n >> 1;
            }
            Console.WriteLine(s);
            return s;
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double a = (Math.Pow(2, 8 * m) - 1 - Math.Pow(2, 8 * m - 8) - 1);
            double b = (Math.Pow(2, 8 * k) - 1 - Math.Pow(2, 8 * k - 8) - 1);
            Console.WriteLine(Bin(a));
        }
    }
}