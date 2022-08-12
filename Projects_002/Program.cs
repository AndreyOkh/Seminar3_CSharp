// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

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