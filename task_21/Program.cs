int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x1 = EnterData("Введите координату X1: ");
int y1 = EnterData("Введите координату Y1: ");
int z1 = EnterData("Введите координату Z1: ");
Console.WriteLine($"Координаты первой точки - ({x1}, {y1}, {z1})");
Console.WriteLine();
int x2 = EnterData("Введите координату X2: ");
int y2 = EnterData("Введите координату Y2: ");
int z2 = EnterData("Введите координату Z2: ");
Console.WriteLine($"Координаты второй точки - ({x2}, {y2}, {z2})");
Console.WriteLine();

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками = {result}");