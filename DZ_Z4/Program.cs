// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите первое число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число с:");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine($"Максимальное из введенных чисел {max}.");
