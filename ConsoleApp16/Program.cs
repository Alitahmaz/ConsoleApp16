namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("1 ci eded daxil edin:");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci eded daxil edin:");
           int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a == 20 || b == 20 || (a + b == 20));
        }
    }
}