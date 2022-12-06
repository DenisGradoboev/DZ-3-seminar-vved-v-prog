//Задача 19
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
int Num = int.Parse(Console.ReadLine());

if ((Num < 100000) && (Num >= 10000))
{
    int a = Num % 10 ; int b = Num / 10000;
    int c = (Num % 100) / 10 ; int d = (Num / 1000) % 10;

        if (a == b && c == d)
        {
            Console.Write($"Число палиндром: {Num} ");
        }
        else 
        {
            Console.Write($"Число непалиндром: {Num} ");
        }return;
}
Console.Write("Введено непятизначное число: ");
