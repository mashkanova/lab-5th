using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5th
{
    public class Flowers : Goods, IProduct
    {
        public int Number { get; set; }
        public string Blossom { get; set; }
        public Flowers(int id, int number, string blossom) : base(id)
        {
            Number = number;
            Blossom = blossom;
        }
        public override void ToString()
        {
            Console.WriteLine($" Цветы {Blossom} количество {Number} (id={idNum})");
        }
        public override void Sold()
        {
            Console.WriteLine("Цветы в наличии");
        }
        void IProduct.Sold()
        {
        }
    }
}
