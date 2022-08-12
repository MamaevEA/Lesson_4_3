// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите точку ");
// Console.WriteLine("Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите точку ");
// Console.WriteLine("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int chet = 0;

// if (x > 0 && y > 0) Console.Write("Координаты находятся в первой четверти");
// else if (x > 0 && y < 0) Console.Write("Координаты находятся во второй четверти");
// else if (x < 0 && y > 0) Console.Write("Координаты находятся в третье четверти");
// else if (x < 0 && y < 0) Console.Write("Координаты находятся в четвертой четверти");
// else Console.Write("Некорретно введены данные");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти ");
// int qoerterNumber = Convert.ToInt32(Console.ReadLine());

// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

// Console.WriteLine("Введите координату Х точки А ");
// int xa = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y точки А ");
// int ya = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Х точки B ");
// int xb = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Х точки B ");
// int yb = Convert.ToInt32(Console.ReadLine());

// // double line = Math.Sqrt(((xa - ya) * (xa - ya)) + ((ya - yb) * (ya - yb)));
// double line = Math.Sqrt((Math.Pow((xa - ya),2) + Math.Pow((xb - yb),2)));


// Console.Write("Расстояние между точками: ");
// Console.WriteLine(Math.Round (line, 2));

// 22. Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите целое число от 1 до N для нахождения квадратов всех чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= n)
{
    Console.WriteLine($" {count} -> {Math.Pow(count, 2)}");
    count++;
}