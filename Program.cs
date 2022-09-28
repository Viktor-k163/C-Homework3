/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = n % 10;
int a = n / 10000;
if (i == a)
{
    Console.Write($" Число {n} является палиндромом.");
}
else
{
    Console.Write($" Число {n} не является палиндромом.");
}


/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.Write("Введите координату точки x1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки y1: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки z1: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x,2) + Math.Pow(y2 - y,2) + Math.Pow(z2 - z,2) );
Console.WriteLine($"Расстояние между точками = {result:f2}");*/

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int result = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{result} ");
}*/
    


