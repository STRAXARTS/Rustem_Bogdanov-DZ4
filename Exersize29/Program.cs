// Задача 29: Напишите программу, которая принимает на вход длину массива и 
// в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33] 
Console.Write("Enter array length: ");
int l = Convert.ToInt32(Console.ReadLine());
int [] array = new int[l];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter array element {count}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    count++;
}
Console.WriteLine();
Console.Write($"array length: {l}.  array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();

Console.WriteLine("vertical: ");
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);
