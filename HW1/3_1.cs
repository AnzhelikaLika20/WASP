using System.Runtime.Intrinsics.X86;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            double cnt = 0;
            for(int i = 0; i < n; i++)
            {
                cnt += Math.Pow(a[i], p);
            }
            Console.WriteLine(Math.Pow(cnt, 1.0 / p));
        }
    }
}