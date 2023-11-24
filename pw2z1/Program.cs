using System;

namespace pw2z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c:");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            equation.CalculateRoots();
            double discriminant = equation.GetDiscriminant();
            double[] roots = equation.GetRoots();
            Console.WriteLine($"Дискриминант: {discriminant}");
            if (discriminant > 0)
            {
                Console.WriteLine($"Первый корень: {roots[0]}");
                Console.WriteLine($"Второй корень: {roots[1]}");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Единственный корень: {roots[0]}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

            Console.ReadLine();
        }
    }
    public class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        private double discriminant;
        private double[] roots;
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            discriminant = 0;
            roots = new double[2];
        }
        public void CalculateRoots()
        {
            discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
                roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                roots[0] = -b / (2 * a);
            }
            else
            {
                roots[0] = roots[1] = double.NaN;
            }
        }
        public double GetDiscriminant()
        {
            return discriminant;
        }
        public double[] GetRoots()
        {
            return roots;
        }
    }
}
