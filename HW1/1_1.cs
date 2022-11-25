namespace wasp_дз
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 9; i >= 3; i--)
            {
                for(int j = i - 1; j >= 2; j--)
                {
                    for(int k = j - 1; k >= 1; k--)
                    {
                        for(int p = k - 1; p >= 0; p--)
                        {
                            Console.WriteLine($"{i}{j}{k}{p}");
                        }
                    }
                }
            }
        }
    }
}