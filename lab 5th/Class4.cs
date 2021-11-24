using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5th
{

    public class Candies : Confectionary, IProduct
    {
        public float Weight { get; set; }
        public Candies(int id, string taste, float weight) : base(id, taste)
        {
            Weight = weight;
        }
        public override void ToString()
        {
            Console.WriteLine($" Вкус конфет - {Taste}, вес {Weight}кг. (id={idNum}) ");
        }
        public override void Sold()
        {
        }
        void IProduct.Sold()
        {
        }
    }
}
