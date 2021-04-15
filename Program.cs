using System;

namespace Lab_1_1
{
    class Program
    {
        delegate double Anonim(double A, double B, double C);
        static void Main(string[] args)
        {
            Console.WriteLine("Перше число -->");
            double A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Друге число -->");
            double B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третє число -->");
            double C = Convert.ToInt32(Console.ReadLine());

            Anonim del = (a,b,c) => (double)(A + B + C) / 3;
            Console.WriteLine("Середне арифметичне введених чисел {0:##.###}", del(A,B,C));

            Console.ReadLine();
        }
    }
}
