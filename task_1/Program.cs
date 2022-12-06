Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int a = n / 10;
int b = a % 10;

Console.WriteLine(b);