// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например: 4 -> 16 -3 -> 9 -7 -> 49
Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine()!);
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
// double square2 = Math.Pow(number, 2);
Console.WriteLine($"Квадрат числа {number} равен {square}");
// Console.WriteLine($"Квадрат числа {number} равен {square2}");