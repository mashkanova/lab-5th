using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5th
{
    public class Cake : Confectionary, IProduct
    {
        public float Weight { get; set; }
        public string Cream { get; set; }
        public Cake(int id, string taste, float weight, string cream) : base(id, taste)
        {
            Weight = weight;
            Cream = cream;
        }
        public override void ToString()
        {
            Console.WriteLine($" Торт - {Taste} с {Cream} кремом весом {Weight}кг. (id={idNum}) ");
        }
        public override void Sold()
        {
            Console.WriteLine("Торт продан");
        }

        void IProduct.Sold()
        {
        }
    }
}
