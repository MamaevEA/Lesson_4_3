// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите точку ");
Console.WriteLine("Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точку ");
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int chet = 0;

if (x > 0 && y > 0)
{
   Console.Write("Координаты находятся в первой четверти");
}
else if (x < 0 && y > 0)
{
   Console.Write("Координаты находятся во второй четверти");
}
else if (x < 0 && y > 0)
{
   Console.Write("Координаты находятся в третье четверти");
}
else if (x < 0 && y < 0)
{
   Console.Write("Координаты находятся в четвертой четверти");
}
else if (x == 0 || y == 0)
{
   Console.Write("Некорретно введены данные");
}
