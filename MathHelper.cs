//using lab02;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab02
//{
//    internal class mathhelper
//    {
//        public void swapintegers(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }

//        public void dividewithremainder(int divisor, out int quotient, int dividend, out int remainder)
//        {
//            quotient = dividend / divisor;
//            remainder = dividend % divisor;
//        }
//    }
//}

//class program
//{

//    public static void Main(string[] args)
//    {
//        int a, b;
//        Console.WriteLine("enter details for swapping: ");
//        Console.Write("first number: ");
//        a = int.Parse(Console.ReadLine());
//        Console.Write("second number: ");
//        b = int.Parse(Console.ReadLine());

//        mathhelper helper = new mathhelper();
//        Console.WriteLine("values before swapping");
//        Console.WriteLine($"a: {a}");
//        Console.WriteLine($"b: {b}");
//        Console.WriteLine();

//        helper.swapintegers(ref a, ref b);


//        Console.WriteLine("values after swapping");
//        Console.WriteLine($"a: {a}");
//        Console.WriteLine($"b: {b}");

//        int dividend, divisor, remainder, quotient;
//        Console.Write("dividend: ");
//        dividend = int.Parse(Console.ReadLine());
//        Console.Write("divisor: ");
//        divisor = int.Parse(Console.ReadLine());
//        helper.dividewithremainder(divisor, out quotient, dividend, out remainder);
//        Console.WriteLine("remainder: " + remainder);
//        Console.WriteLine("quotient: " + quotient);

//    }
//}
