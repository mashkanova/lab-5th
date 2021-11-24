using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_5th;

namespace lab_5th
{
    class Printer
    {
       public static void IAmPrinting(Goods obj)
        {
            Console.WriteLine($"Это объект типа {obj.GetType()}");
        }
    }
    interface IProduct
    {
        void Sold();
    }





    
    public sealed class Watch : Goods, IProduct
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public Watch(int id, string brand, string model) : base(id)
        {
            Brand = brand;
            Model = model;

        }
        public override void ToString()
        {
            Console.WriteLine($" Часы {Brand} модели {Model} (id={idNum})  ");
        }
        public override void Sold()
        {
            Console.WriteLine("Часы в наличии") ;
        }
        void IProduct.Sold()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Flowers flowers = new Flowers(346789, 7, "тюльпаны");
            Watch watch1 = new Watch(4567890, "apple","Series 7");
            Cake cake = new Cake(9876784, "шоколадный", 4, "шоколадный");
            Candies candy = new Candies(367899,"вишневый", 3);
            flowers.ToString();
            watch1.ToString();
            cake.ToString();
            candy.ToString();
            cake.Sold();
            Goods[] products = new Goods[4] {flowers, watch1,cake,candy};
            for (int i = 0; i < 4; i++)
            {
                products.ToString();
                Printer.IAmPrinting(products[i]);

            }
            ((IProduct)cake).Sold();
            Boolean flower = (flowers is Flowers);
            Boolean watch = watch1 is Flowers;
            Console.WriteLine($"Имеет ли объект flower совместимость с типом Flowers? - {flower}");
            Console.WriteLine($"Имеет ли объект watch совместимость с типом Flowers? - {watch}");
        }
    }
}
