// Задача 46: Написать программу масштабирования фигуры.
Console.Write("Введите координаты вершин фигуры в формате (x,y): ");
string coordinates = Console.ReadLine()
                    .Replace("(", "")
                    .Replace(")", "");
Console.Write("Необходим масштаб 1 к ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine(coordinates);

var result = coordinates.Split(" ")
                        .Select(item => item.Split(','))
                        .Select(n => (x: int.Parse(n[0]), y: int.Parse(n[1])))
                        .Select(point => (point.x * size, point.y * size))
                        .ToArray();

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
