// Задача 27: Напишите программу, которая принимает на вход число и 
//            выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0) a = a * -1;
int ost = a;
int sum = 0;
while (ost > 0)
{
    ost = a % 10;
    sum = sum + ost;
    a = (a - ost)/10;
}
sum = sum + a;
Console.WriteLine(sum);
