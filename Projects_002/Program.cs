// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int x = ReadInt("Введите четверть: ");

if (x == 1)
{
    Console.WriteLine("x > 0 && y > 0.");
}
else if (x == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (x == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else 
{
    Console.WriteLine("Нет такой четверти!");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}