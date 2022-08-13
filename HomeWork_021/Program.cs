// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату Х для точки А: ");
int y1 = ReadInt("Введите координату У для точки А: ");
int z1 = ReadInt("Введите координату Z для точки А: ");
int x2 = ReadInt("Введите координату Х для точки B: ");
int y2 = ReadInt("Введите координату У для точки B: ");
int z2 = ReadInt("Введите координату Z для точки B: ");


double x = (x2 - x1) * (x2 - x1);
double y = (y2 - y1) * (y2 - y1);
double z = (z2 - z1) * (z2 - z1);

double result = Math.Sqrt(x + y + z);

Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}