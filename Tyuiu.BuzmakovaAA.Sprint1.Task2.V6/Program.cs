using Tyuiu.BuzmakovaAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.BuzmakovaAA.Sprint1.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Бузмакова А. А. | АСОиБУ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Бузмакова Алина Альбертовна | АСОиБУ-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* vaulue / 1000                                                           *");
            
            int vaulue = 1000;

            Console.WriteLine("Введите значение vaulue:");
            vaulue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate( vaulue));


            Console.ReadLine();
        }
    }
}

