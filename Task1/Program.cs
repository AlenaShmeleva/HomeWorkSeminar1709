// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое большее, а какое - меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + " - большее число");
    Console.WriteLine(b + " - меньшее число");
}
else
{ 
    if (a == b) 
        Console.WriteLine("Числа равны ");
    else
    {
        Console.WriteLine(a + " - меньшее число");
        Console.WriteLine(b + " - большее число");
    }
}
