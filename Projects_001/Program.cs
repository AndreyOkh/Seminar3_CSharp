// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите первое число ");
int y = ReadInt("Введите второе число ");

if (x == 0 || y == 0)
{
    Console.WriteLine("Четверть определить невозможно, одно из значений равно 0.");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Четверть 1.");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Четверть 2.");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Четверть 3.");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Четверть 4.");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}