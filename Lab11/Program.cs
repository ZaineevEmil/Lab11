using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Решение уравнения с одной переменной
            Console.WriteLine("Программа решения уравнения с одной переменной.\n\nВведите значения k и b в уравнении типа: 0=kx+b");
            Console.Write("k - ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb - ");
            double b = Convert.ToDouble(Console.ReadLine());
            UravnenieOdnaPeremennaya uravnenieOdnaPeremennaya = new UravnenieOdnaPeremennaya { k = k, b = b };
            uravnenieOdnaPeremennaya.Root();
            Console.ReadKey();
        }
        struct UravnenieOdnaPeremennaya
        {
            public double k;
            public double b;
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("\nx равняется: {0}", x);
            }
        }
    }
}
