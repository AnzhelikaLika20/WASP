using System.Runtime.Intrinsics.X86;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            string s = Console.ReadLine();
            int[] c = Array.ConvertAll(s.Split(':'), int.Parse);
            if (c[1] < 0)
                c[1] = n + c[1];
            int[] b = new int[n];
            int cnt = 0;
            if (c[2] > 0)
            {
                int j = 0;
                for(int i = c[0]; i <= c[1]; i += c[2])
                {
                    b[j++] = a[i];
                    cnt++;
                }
            }
            else
            {
                int j = 0;
                for(int i = c[1]; i >= c[0]; i += c[2])
                {
                    b[j++] = a[i];
                    cnt++;
                }
            }
            for(int i = 0; i < cnt; i++)
                Console.WriteLine(b[i]);
        }
    }
}