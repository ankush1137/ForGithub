using AkashDemo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter first Number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second Number");
        int b = int.Parse(Console.ReadLine());

        Calculation calculation = new Calculation();
        calculation.Add(a,b);

        Console.ReadLine();
    }
}