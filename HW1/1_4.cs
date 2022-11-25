namespace _1._4
{
    internal class Program
    {
        public static int Fact(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;
            return Fact(n - 1) * n;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j <  i + 1; j++)
                {
                    Console.Write($"{Fact(i) / (Fact(j) * Fact(i - j))} ");
                }
                Console.WriteLine();
            }
        }
    }
}