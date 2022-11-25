// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. 14212 -> нет; 23432 -> да; 12821 -> да.

void Task19()
{
    Console.WriteLine("Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    int length = number.Length;
    if (length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Число {number} - является палиндромом.");
        else Console.WriteLine($"Число {number} - не является палиндромом.");
    }
    else Console.WriteLine($"Число введено неверно. Число {number} не является пятизначным.");
}

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53.

void Task21_1 ()
{
    Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("Введите координаты 1-ой точки: ");
    Console.Write("x1 = ");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y1 = ");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z1 = ");
    double z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату 2-ой точки: ");
    Console.Write("x2 = ");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y2 = ");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z2 = ");
    double z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Расстояни между точками = " + Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) 
                                                    + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2));
}

void Zadacha21_2()
{
    Console.WriteLine("Введите координаты точки А через пробел:");
    string pointA = Console.ReadLine();
    Console.WriteLine("Введите координаты точки В через пробел:");
    string pointB = Console.ReadLine();

    string[] pointASplit = pointA.Split();
    string[] pointBSplit = pointB.Split();

    double distance = Math.Round(Math.Sqrt(Math.Pow(Convert.ToInt32(pointASplit[0]) - Convert.ToInt32(pointBSplit[0]), 2)
                    + Math.Pow(Convert.ToInt32(pointASplit[1]) - Convert.ToInt32(pointBSplit[1]), 2) 
                    + Math.Pow(Convert.ToInt32(pointASplit[2]) - Convert.ToInt32(pointBSplit[2]), 2)), 2);

    Console.WriteLine($"Расстояни между точками = {distance}.");
}

// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125.

void Task23()
{
    Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N (введённого числа) включительно.");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++) Console.WriteLine($" {i}^3 = {Math.Pow(i, 3)}");
    if (1 > number) Console.WriteLine("Число введено неверно.");
}

Task19();
Task21_1();
Zadacha21_2();
Task23();