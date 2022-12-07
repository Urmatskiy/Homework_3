Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int start = 1;
while (start <= N)
{
    Console.Write((Math.Pow((start), 3)) + ", ");
    start++;
}