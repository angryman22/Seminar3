// Напишите программу, которая принимает на вход координаты точки (x и y). причем х != 0 и у != 0 и выдает номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координаты точки по оси x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки по оси y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Введенная точка лежит в 1 четверти");
// else if (x < 0 && y > 0) Console.WriteLine("Введенная точка лежит во 2 четверти");
// else if (x < 0 && y < 0) Console.WriteLine("Введенная точка лежит в 3 четверти");
// else if (x > 0 && y < 0) Console.WriteLine("Введенная точка лежит в 4 четверти");
// else Console.WriteLine("Введенная точка лежит на оси координат");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int quater = Convert.ToInt32(Console.ReadLine());
// if (quater < 1 || quater > 4) Console.WriteLine("Нет такой четверти");
// if (quater == 1) Console.WriteLine("x > 0 и y > 0");
// if (quater == 2) Console.WriteLine("x < 0 и y > 0");
// if (quater == 3) Console.WriteLine("x < 0 и y < 0");
// if (quater == 4) Console.WriteLine("x > 0 и y < 0");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координаты первой точки по оси x");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты первой точки по оси y");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки по оси x");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки по оси y");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
// Console.WriteLine("Расстояние между точками " + Math.Round(dist, 2));

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while ( i <= N)
// {
//     int square = i*i;
//     i++;
//     Console.Write(" " + square + " ");
// }




// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Введенное число не является палиндромом");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки по оси x");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси y");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси z");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси x");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси y");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси z");
double z2 = Convert.ToDouble(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine("Расстояние между точками " + Math.Round(dist, 2));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while ( i <= N)
{
    double coub = Math.Pow(i, 3);
    i++;
    Console.Write(" " + coub + " ");
}
