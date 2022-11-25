using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Array.Sort(a);
            int cnt = 1;
            int mx = a[0];
            int j = 0;
            while(cnt != k)
            {
                if (a[j] > mx)
                {
                    cnt++;
                    mx = a[j];
                }
                j++;
            }
            Console.WriteLine(mx);
        }
    }
}