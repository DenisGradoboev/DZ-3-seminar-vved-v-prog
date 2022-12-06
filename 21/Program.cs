//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
    Console.Write("Введите координаты х1: ");
    float x1 = float.Parse(Console.ReadLine());
    Console.Write("Введите координаты y1: ");
    float y1 = float.Parse(Console.ReadLine());
    Console.Write("Введите координаты z1: ");
    float z1 = float.Parse(Console.ReadLine());
    Console.Write("Введите координаты х2: ");
    float x2 = float.Parse(Console.ReadLine());
    Console.Write("Введите координаты y2: ");
    float y2 = float.Parse(Console.ReadLine());
    Console.Write("Введите координаты z2: ");
    float z2 = float.Parse(Console.ReadLine());
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Дистанция между координатами \n" + d);