using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим координаты вершин

            Console.WriteLine("Enter coordinare x of dot A");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinare y of dot A");
            double ay = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinare x of dot B");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinare y of dot B");
            double by = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinare x of dot C");
            double cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinare y of dot C");
            double cy = double.Parse(Console.ReadLine());

            //Находим длину сторон 

            double a = Math.Sqrt(Math.Pow(ay - ax, 2) + Math.Pow(bx - by, 2));
            double b = Math.Sqrt(Math.Pow(by - bx, 2) + Math.Pow(cx - cy, 2));
            double c = Math.Sqrt(Math.Pow(cy - cx, 2) + Math.Pow(ax - ay, 2));

            Console.WriteLine("\n");

            //Выводим длину сторон в консоль

            Console.WriteLine("Length of AB is: " + a);
            Console.WriteLine("Length of BC is: " + b);
            Console.WriteLine("Length of AC is: " + c);

            Console.WriteLine("\n");

            //Создаем переменные для дальнейшего определения углов

            double corner_a = 0;
            double corner_b = 0;
            double corner_c = 0;

            //Ищем углы 

            corner_a = (((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180)) / Math.PI);
            corner_b = (((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180)) / Math.PI);
            corner_c = (((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180)) / Math.PI);

            //Выполняем проверки для определения типа

            if ((a < b + c) & (b < c + a) & (c < b + a))
            {
                if ((a == b) && (b == c) && (c == a)) Console.WriteLine("Triangle is Equilateral");
                else
                    Console.WriteLine("Triangle is not Equilateral");

                if ((a == b) || (b == c) || (c == a)) Console.WriteLine("Triangle is Isosceles");
                else
                    Console.WriteLine("Triangle is not Isosceles");

                if ((corner_a == 90) || (corner_b == 90) || (corner_c == 90)) Console.WriteLine("Triangle is Right");
                else
                    Console.WriteLine("Triangle is not Right");
            }

            //Доп.проверка для условия, если введенные координаты не образуют треугольник

            else
                Console.WriteLine("Is not Triangle");

            Console.WriteLine("\n");

            //Находим периметр треугольника

            double P = a + b + c;

            Console.WriteLine("Perimeter: " + P);

            Console.WriteLine("\n");

            //Выводим все парные числа от 0 до величины периметра (целое число)

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter: \n");
            int m = 0;
            int n = Convert.ToInt32(P);
            for (int i = m; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " " + "\n");
                }

            }

            //Ожидание ввода для закрытия программы

            Console.ReadKey();
        }
    }
}
