using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5th
{

        public abstract class Goods
        {
            public int idNum { get; set; }
            public Goods(int id)
            {
                idNum = id;
            }
            public override void ToString()
            {
                Console.WriteLine($"(id={idNum}) ");
            }
            public abstract void Sold();
        }
    
}
