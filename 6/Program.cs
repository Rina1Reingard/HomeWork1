Console.WriteLine("Напишите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;

if(b > 0)
{
    Console.Write ("нет");
}
else 
{
    Console.Write ("да");
}