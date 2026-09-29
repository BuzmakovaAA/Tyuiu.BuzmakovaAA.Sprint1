using Tyuiu.BuzmakovaAA.Sprint1.Task3.V3.Lib;
namespace Tyuiu.BuzmakovaAA.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бузмакова А. А. | АСОиБУ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Бузмакова Алина Альбертовна | АСОиБУ-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double length = 9;
            double width = 7.5;
            double height = 5;
            Console.WriteLine("Ребро А параллелипипеда = " + length);
            Console.WriteLine("Ребро В параллелипипеда = " + width);
            Console.WriteLine("Ребро С параллелипипеда = " + height);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объём параллелипипеда = " + ds.ParallelepipedVolume(length, width, height));

            Console.ReadKey();
        }
    }
}
