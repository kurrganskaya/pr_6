// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
Console.WriteLine("Введите значение k1 для уравнения y = k1 * x + b1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1 для уравнения y = k1 * x + b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2 для уравнения y = k2 * x + b2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2 для уравнения y = k2 * x + b2: ");
int b2 = int.Parse(Console.ReadLine());
double y = ((b1*k2 - k1*b2)/(k2-k1));
double x = (y-b1)/k1;
Console.WriteLine("Точка пересечения прямых, заданных уравнениями: " + x + " ," + y);
