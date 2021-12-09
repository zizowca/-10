using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение градуса угла:\t");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение минут угла:\t");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение секунд угла:\t");
            int sec = Convert.ToInt32(Console.ReadLine());
            double radG = gradus * (Math.PI / 180);
            double radM = min * (Math.PI / (180 * 60));
            double radS = sec * (Math.PI / (180 * 60 * 60));
            double rad = radG + radM + radS;
            Console.WriteLine(radG);

            Console.ReadKey();
        }
    }
}
