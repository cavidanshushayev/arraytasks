namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 24, 25, 26, 27, 28, 29, 30 };
            int cem = 0;
            int say = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                cem = cem + arr[i];
                say ++;
            }
            Console.WriteLine(cem / say);
        }
    }
}