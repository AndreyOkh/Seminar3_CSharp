// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int x1 = ReadInt("Введите первую координату Х ");
int y1 = ReadInt("Введите первую координату У ");
int x2 = ReadInt("Введите вторую координату Х ");
int y2 = ReadInt("Введите вторую координату У ");

double xGep = (x2 - x1) * (x2 - x1);
double yGep = (y2 - y1) * (y2 - y1);

double Gep = Math.Sqrt(xGep + yGep);

Console.WriteLine(Gep);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}