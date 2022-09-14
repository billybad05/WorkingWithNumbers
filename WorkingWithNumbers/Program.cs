namespace WorkingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + add, - subtract, * times, / Divide, % Modulo
            int num = 6;
            num++; // add 1 to num
            num--; // subtracts 1 from num
            Console.WriteLine(num);
            Console.ReadLine();
            // Math. calls different math methods
            Console.WriteLine(Math.Abs(-40));//absolute value
            Console.WriteLine(Math.Sqrt(36));// square root
            Console.WriteLine(Math.Max(4, 90));// Highest number
            Console.WriteLine(Math.Round(4.6));// rounds the number
            Console.ReadLine();
        }
    }
}