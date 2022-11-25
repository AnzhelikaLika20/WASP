using System.Text;

namespace _2._2
{
    internal class Program
    {
        public static string Bin(int n)
        {
            string s = String.Empty;
            while (n > 0)
            {
                s = (n % 2).ToString() + s;
                n /= 2;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string n1 = Bin(n);
            string m1 = Bin(m);
            string s1 = Bin(m + n);
            int len = Math.Max(Math.Max(n1.Length, m1.Length), s1.Length);
            int c1 = len - n1.Length;
            while (c1 > 0)
            {
                c1--;
                Console.Write("0");
            }
            Console.WriteLine(n1);
            c1 = len - m1.Length;
            while (c1 > 0)
            {
                c1--;
                Console.Write("0");
            }
            Console.WriteLine(m1);
            for(int i = 0; i < len; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine(s1);
        }
    }
}