Console.WriteLine ("введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine ("Является квадратом второго числа");
}
else
{
    Console.WriteLine ("Первое число не является квадратом второго числа");
}