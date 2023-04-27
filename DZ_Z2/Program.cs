// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Введите первое число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max > numberB)
{
    Console.WriteLine($"Первое число  {numberA} большее. Второе число  {numberB} меньшее.");   
}
else
if (max < numberB)
{
Console.WriteLine($" Первое число {numberA} меньшее. Второе число {numberB} большее.");
}
else
{
  Console.WriteLine($"Введите разные числа.");  
}