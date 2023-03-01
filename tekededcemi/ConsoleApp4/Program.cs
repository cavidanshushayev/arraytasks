namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 13, 14, 15, 16 };
            int cem = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 != 0)
                {
                    cem = cem + arr[i];
                }
            }
            Console.WriteLine(cem);
        }
    }
}