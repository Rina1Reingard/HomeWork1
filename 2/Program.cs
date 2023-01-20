Console.WriteLine("Напишите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}