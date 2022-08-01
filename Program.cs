using System;

namespace ThirdSeminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

                /* void Numbers(int number){
                    while (number > 99999 || number <= 9999){
                        Console.WriteLine("Вы ввели неверное число. Попробуйте снова.");
                        Console.Write("Введите пятизначное число для проверки является ли оно палиндромом ");
                        number = Convert.ToInt32(Console.ReadLine());
                    }

                    int num1 = number % 10;
                    int num2 = number / 10 % 10;
                    int num4 = number / 1000 % 10;
                    int num5 = number / 10000 % 10;
                    
                    if (num1 == num5){
                        if (num2 == num4) {
                            Console.WriteLine("Число является полиндромом");
                        }
                        else Console.WriteLine("Число не является полиндромом!");
                    }

                    else Console.WriteLine("Число не является полиндромом!");
                }

                Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Numbers(number); */


            // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

                /*double Distance (double xa, double xb, double ya, double yb, double za, double zb)
                {
                    double lenth = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
                    return lenth;
                }

                Console.Write("Введите значение координаты Х точки А ");
                int ax = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение координаты Y точки А ");
                int ay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение координаты Z точки А ");
                int az = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите значение координаты Х точки B ");
                int bx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение координаты Y точки B ");
                int by = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение координаты Z точки B ");
                int bz = Convert.ToInt32(Console.ReadLine());

                double lenth = Distance(ax, bx, ay, by, az, bz);
                Console.WriteLine($"Растояние между A и B = {lenth}"); */



            // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

                void CubbedNumbers(int number){

                    if (number < 0){
                        Console.WriteLine("Вы ввели отрицательное число, но программа преобразовала в положительное )");
                        number = number * -1;
                    }

                    if (number == 0){
                        Console.WriteLine("Вы ввели 0, чисел нет!");
                    }

                    int count = 1;
                    while (count <= number){
                        int result = count * count * count;
                        Console.Write(result + " ");
                        count++;
                    }
                }

                Console.WriteLine("Добро пожаловать");
                Console.Write("Введите число N и программа выдаст таблицу кубов чисел от 1 до N ");
                int number = Convert.ToInt32(Console.ReadLine());

                CubbedNumbers(number);
                Console.WriteLine();


        }
    }
}
