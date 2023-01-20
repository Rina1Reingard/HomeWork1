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