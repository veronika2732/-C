// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int f = int.Parse(Console.ReadLine()!);
if (x > y)
{
        Console.WriteLine("Максимальное число: " + x);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + f);
    }

else if (y > f)
{
    Console.WriteLine("Максимальное число: " + y);
}
else
{
    Console.WriteLine("Максимальное число: " + f);
}
    
    