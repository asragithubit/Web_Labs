using Lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Task6
    {
        public (int, int) CalculateRectangleProperties(int length, int width)
        {
            int area = length * width;
            int perimeter = 2 * area;

            return (area, perimeter);
        }
    }
}

class Program
{

    //public static void Main(string[] args)
    //{
    //    Task6 task = new Task6();
    //    int length, width;

    //    Console.Write("Length: ");
    //    length = int.Parse(Console.ReadLine());
    //    Console.Write("Width: ");
    //    width = int.Parse(Console.ReadLine());

    //    (int, int) properties = task.CalculateRectangleProperties(length, width);
    //    Console.WriteLine("Area: " + properties.Item1);
    //    Console.WriteLine("Perimeter: " + properties.Item2);

    //}
}
