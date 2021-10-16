using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число A=");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число B=");
                int b1 = Convert.ToInt32(Console.ReadLine());
                int R1, R2, R3, R4;
                Sum(a1, b1, out R1);
                Sub(a1, b1, out R2);
                Mult(a1, b1, out R3);
                Div(a1, b1, out R4);
                Console.WriteLine("Введите код операции");
                Console.WriteLine("    1 - сложение");
                Console.WriteLine("    2 - вычитание");
                Console.WriteLine("    3 - умножение");
                Console.WriteLine("    4 - частное");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", c);
                if (c == 1)
                {
                    Console.WriteLine("Результат ={0}", R1);
                }
                if (c == 2)
                {
                    Console.WriteLine("Результат ={0}", R2);
                }
                if (c == 3)
                {
                    Console.WriteLine("Результат ={0}", R3);
                }
                if (c == 4)
                {
                    Console.WriteLine("Результат ={0}", R4);
                }
                if (c != 1 && c != 2 && c != 3 && c != 4)
                {
                    Console.WriteLine("Операции с введенным кодом не существует");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            
            Console.ReadKey();
        }
        static void Sum(int a, int b, out int R)
        {
            R = a + b;
        }
        static void Sub(int a, int b, out int R)
        {
            R = a - b;
        }
        static void Mult(int a, int b, out int R)
        {
            R = a * b;
        }
        static void Div(int a, int b, out int R)
        {
            R = a / b;
        }
    }



}


