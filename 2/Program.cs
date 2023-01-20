Console.WriteLine("Напишите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}

else if(a < b)
{
    Console.Write("max = ");
    Console.Write(b);
}

else
{
    Console.Write("числа равны");
}