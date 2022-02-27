// Задача 46: Написать программу масштабирования фигуры.
Console.Write("Введите параметры фигуры: A - ");
int a = int.Parse(Console.ReadLine());
Console.Write("B - ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Необходим масштаб 1 к ");
int size = int.Parse(Console.ReadLine());
double newA = a * size;
double newB = b * size;
Console.WriteLine($"Параметры фигуры в масштабе 1:{size} - {newA}x{newB}."); 
