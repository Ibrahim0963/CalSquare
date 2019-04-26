using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalSquare
{
    class Program
    {
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
        public double Length;
        public double Breadth;
        public void SqrBreadth()
        {
            Console.Write("breadth : ");
            Breadth = Read();
        }
        public void SqrLength()
        {
            Console.Write("length : ");
            Length = Read();
        }
        static void Main(string[] args)
        {
            Console.Write("\n\nCalculate the Perimeter and Area of the square  :\n");
            Console.Write("-----------------------------------------------------\n");
            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            Program p = new Program();
            p.SqrLength();
            p.SqrBreadth();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", p.Length);
            Console.WriteLine("Breadth:    {0}", p.Breadth);
            Console.WriteLine("Perimeter: {0}", (p.Length + p.Breadth) * 2);
            Console.WriteLine("Area:      {0}\n", p.Length * p.Breadth);

            Console.ReadKey();
        }
    }
}
