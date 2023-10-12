// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 не равное нулю: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == 0) 
    Console.WriteLine("Введите число 2 не равное нулю");
else if (b < 0)
{
    b = b * -1;
    int c = Convert.ToInt32(Math.Pow(a,b));
    Console.WriteLine($"result {c}");
}
else
{   
    int c = Convert.ToInt32(Math.Pow(a,b));
    Console.WriteLine($"result {c}");
}