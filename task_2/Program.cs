Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int result_a = n%10;

if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    if (n < 1000)
    {
        Console.WriteLine(result_a);
    }
    else
    {
        while (n >= 1000)
        {
            n = n / 10;
        }
        int result_b = n%10;
        Console.WriteLine(result_b);
    }
}