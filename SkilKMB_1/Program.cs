using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilKMB_1
{
    class Program
    {

      static  public void First()
        {

            Console.WriteLine("Введите число X");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите точность");
            double eps = Convert.ToDouble(Console.ReadLine());

            

            double S = 0;

            int n = 0;

            double an = (Math.Pow((X - 1), n + 1)) / ((n + 1) * Math.Pow(X, n + 1));
            //Console.WriteLine(an);
            eps = 0.0001;
            while (Math.Abs(an) >= eps)
            {
                S += (Math.Pow((X - 1), n + 1)) / ((n + 1) * Math.Pow(X, n + 1));
               
                n++;
                an = (Math.Pow((X - 1), n + 1)) / ((n + 1) * Math.Pow(X, n + 1));
              
            }

            Console.WriteLine(S);




        }




        static public void Second()
        {

            Console.WriteLine("Введите точность например [0,0001] ");
            double eps = Convert.ToDouble(Console.ReadLine());  //точность 

            if (eps > 0.1)
            {
                Console.WriteLine("Ошибка ввода");
            }
            else
            {
                double S = 0; // сумма ряда
                int n = 0;// итерации
                double an = an = (1) / Math.Pow(((2 * n) + 1), 2); // Модуль этого значения будет сравниваться с точностью 
                eps = 0.00001;  //точность 
                while (Math.Abs(an) >= eps)
                {
                    an = (1) / Math.Pow(((2 * n) + 1), 2);

                    S += (1) / Math.Pow(((2 * n) + 1), 2);
                    n++;

                }

                Console.WriteLine(S);  // ответ будет  приблизительно равен 1.2...........     
                                       //проверка значения (PI^2)/8 = 1.2337


            }






        }



        static void Third()
        {
       

                double a = 0;
                double b = 0;
                double aa = 0; //значение a в прошлой итерации
                double bb = 0;//значение b в прошлой итерации
                double eps = 0.0001;


                Console.WriteLine("Введите X:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Y:");
                int y = Convert.ToInt32(Console.ReadLine());
                a = x;
                b = y;

                a = 0.5 * ((a - 1) + (b - 1));   //A1
                b = Math.Sqrt((a - 1) * (b - 1));  //B1

                double min = Math.Abs(a - b);




                while (min > eps)
                {

                    aa = 0.5 * (a + b);
                    bb = Math.Sqrt(a * b);
                    a += 0.5 * (aa + bb);   //A1
                    b += Math.Sqrt(aa * bb);  //B1
                    min = Math.Abs(a - b);

                }
                Console.WriteLine(a);
                Console.WriteLine(b);



            

        }

        static void Main(string[] args)
        {
            // First(); // Первое задание
            //  Second(); // Второе задание вариант 20 но 20-нет поэтому вариант 10

            //Third(); // 3 задание 10 вариант

            Console.ReadKey();

        }
    }
}
