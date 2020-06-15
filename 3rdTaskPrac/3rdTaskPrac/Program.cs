using System;

namespace _3rdTaskPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok=true;
            double x = 0, y = 0;
            do
            {
                try
                {

                    Console.WriteLine("Введите x:");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите y:");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error!");
                    ok = false;
                }
            } while (ok == false);
            double u = 0;
            double y1 = Math.Pow(x,2);
            double e = 2.7;
            double y2 = Math.Pow(e, x);
            double y3 = Math.Pow(e, -x);
            if (x>=y1 && y>=y1 && x<=y2 && y<=y2 && x<=y3 && y<=y3) u = x + y;
            else u = x - y;
            Console.WriteLine($"u equals {u}");
        }
    }
}
