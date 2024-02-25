using Lab02;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class ShoppingCart
    {
        public double CalculateTotalPrice(List<double> ItemPrices, double discount = 0)
        {
            int length = ItemPrices.Count;
            double sum = 0;
            for(int i=0;i<length;i++)
            {
                sum = sum + ItemPrices[i];
            }

            return sum - discount;


        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<double> items = new List<double>();
        double discount;
        int numberOfItems;
        Console.Write("Number of Items: ");
        numberOfItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            items.Add(double.Parse(Console.ReadLine()));
        }
        Console.Write("Discount: ");
        discount = double.Parse(Console.ReadLine());

        ShoppingCart cart = new ShoppingCart();
        double price = cart.CalculateTotalPrice(items, discount);
    }
}
