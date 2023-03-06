internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um valor para calcular a tabuada: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{value} x {i} = {value * i}");
        }
    }
}