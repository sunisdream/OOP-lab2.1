using System;

namespace OOP_lab_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (int.Parse(Console.ReadLine()) / 1000)
            {
                case 79:
                    Console.WriteLine("Львiв.");
                    break;
                case 21:
                    Console.WriteLine("Вiнниця.");
                    break;
                case 10:
                    Console.WriteLine("Житомир.");
                    break;
                case 46:
                    Console.WriteLine("Тернопiль.");
                    break;
                case 57:
                    Console.WriteLine("Миколаїв.");
                    break;
                case 58:
                    Console.WriteLine("Чернiвцi.");
                    break;
                case 18:
                    Console.WriteLine("Черкаси.");
                    break;
                case 65:
                    Console.WriteLine("Одеса.");
                    break;
                case 36:
                    Console.WriteLine("Полтава.");
                    break;
                case 49:
                    Console.WriteLine("Днiпро.");
                    break;
            }
        }
    }
}
