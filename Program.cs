
/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine ()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine ()!);
if (a>b)
{
    Console.WriteLine($"Большее число - {a}, меньшее число - {b}");
}
else
{
    Console.WriteLine($"Большее число - {b}, меньшее число - {a}");
}
*/





/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine ()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine ()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine ()!);
int max = 0;
if (a>b)
{
    if (a>c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
    
}
else 
{
    if (b>c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
    
}
Console.WriteLine($"Максимальное число: {max}");
*/



/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine ()!);
//int a = Convert.ToInt32(Console.ReadLine());
if ((a%2) == 0)
{
    Console.WriteLine($"Число {a} - четное");
}
else
{
    Console.WriteLine($"Число {a} - нечетное");
}
*/




//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine ()!);
for (int N2 = 1; N2 <= N; N2++)
if (N2%2 == 0)
{
    Console.WriteLine($"Четные числа: {N2}");
}
*/

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine ()!);
int N2 = 1;
while(N2 <= N)
{
    if (N2%2 == 0)
    {
        Console.Write($"{N2} ");
        
    }
    N2++;
}