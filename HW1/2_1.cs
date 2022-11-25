using System.Text;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int i = 0;
            string s = "";
            while(n != 0)
            {
                s = (n & 1).ToString() + s;
                n >>= 1;
            }
            Console.WriteLine(s);
        }
    }
}