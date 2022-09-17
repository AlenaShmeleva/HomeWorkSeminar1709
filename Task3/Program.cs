// Напишите программу, которая на вход принимает число и выдаёт, чётное ли оно.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
    Console.WriteLine(a + " - чётное число");
else
    Console.WriteLine(a + " - нечётное число");
