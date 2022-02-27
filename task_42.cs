// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("Введите числа: ");
var numbers = Console.ReadLine();
var array = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;    
}
Console.WriteLine($"Чисел больше нуля - {count}.");
