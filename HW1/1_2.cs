namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int j = n - i;
                bool flag = false;
                for(int k = 0; k < n; k++)
                {
                    if(j == n + 1)
                    {
                        flag = true;
                        j--;
                    }
                    if(flag)
                    {
                        j--;
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                        j++;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}