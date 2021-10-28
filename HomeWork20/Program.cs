using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20
{
    // Реализовать вызов методов с помощью делегата.
    //public delegate double CircleDelegate(double Input);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления значений характеристик геометрических фигур введите значение радиуса окружности:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());

            Func<double, double> circleDelegate1 = CircleLength;
            circleDelegate1(circleRadius);

            Func<double, double> circleDelegate2 = CircleArea;
            circleDelegate2(circleRadius);

            Func<double, double> circleDelegate3 = SphereVolume;
            circleDelegate3(circleRadius);

            //CircleDelegate circleDelegate1 = new CircleDelegate(CircleLength);
            //circleDelegate1?.Invoke(circleRadius);

            //CircleDelegate circleDelegate2 = new CircleDelegate(CircleArea);
            //circleDelegate2?.Invoke(circleRadius);

            //CircleDelegate circleDelegate3 = new CircleDelegate(SphereVolume);
            //circleDelegate3?.Invoke(circleRadius);

            Console.ReadKey();
        }

        //длину окружности по формуле D = 2 * π* R;
        static double CircleLength(double radius)
        {
            double circleLength = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности = {0:f2}", circleLength);
            return circleLength;
        }

        //площадь круга по формуле S = π* R²;
        static double CircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга = {0:f2}", circleArea);
            return circleArea;
        }

        //объем шара. Формула V = 4/3 * π * R³.
        static double SphereVolume(double radius)
        {
            double sphereVolume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Объем шара = {0:f2}", sphereVolume);
            return sphereVolume;
        }
    }
}
