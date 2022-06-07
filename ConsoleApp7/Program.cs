class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число X ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число Y ");
        int y = int.Parse(Console.ReadLine());
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("Ответ:");
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}