/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Напишите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
    {
        Console.Write (a);
    }
    else 
    {
        Console.Write (c);
    }
}
else if(b > c)
{
    Console.Write (b);
}

else
{
    Console.Write(c);
}