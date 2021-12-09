using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle one = new Angle();
            double oneGradus = one.Gradus;
            double oneMin = one.Min;
            double oneSec = one.Sec;
            Console.Write("Введите значение градуса угла:\t");
            one.Gradus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение минут угла:\t");
            one.Min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение секунд угла:\t");
            one.Sec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введен угол {0}о {1}' {2}''.", one.Gradus, one.Min, one.Sec);
            one.ToRadian();
            Console.ReadKey();
        }
    }
    class Angle
    {
        double gradus;
        double min;
        double sec;

        public double Gradus
        {
            set
            {
                if (value > 360)
                {
                    Console.WriteLine("ERROR");
                }
                else if (value < -360)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    gradus = value;
                }
            }
            get
            {
                return gradus;
            }
        }
        public double Min
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ERROR"); 
                }
                else
                {
                    min = value;
                }
            }
            get
            {
                return min;
            }
        }
        public double Sec
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    sec = value;
                }
            }
            get
            {
                return sec;
            }
        }
        public void EnterValue(double gradus, double min, double sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadian()
        {
            double radG= gradus * (Math.PI / 180);
            double radM = min * (Math.PI / (180 * 60));
            double radS = sec * (Math.PI / (180 * 60 * 60));
            double rad = radG + radM + radS;
            Console.WriteLine("При переводе в радианы получаем {0:f6}",rad);
        }

    }
}
