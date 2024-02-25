//using Lab02;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab02
//{
//    internal class Task3
//    {
//        public void PassByValueAndReference(int value1, ref int value2)
//        {
//            value1 += 10;
//            value2 += 10;
//        }
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        int value1, value2;
//        Console.Write("First Value : ");
//        value1 = int.Parse(Console.ReadLine());
//        Console.Write("Second Value : ");
//        value2 = int.Parse(Console.ReadLine());

//        Task3 task = new Task3();
//        Console.WriteLine("Before Passing By Value and Reference");
//        Console.WriteLine("Value 1: " + value1);
//        Console.WriteLine("Value 2: " + value2);
//        task.PassByValueAndReference(value1, ref value2);
//        Console.WriteLine("After Passing By Value and Reference");
//        Console.WriteLine("Value 1: " + value1);
//        Console.WriteLine("Value 2: " + value2);
//    }
//}
