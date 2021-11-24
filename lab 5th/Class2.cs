using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5th
{
    public abstract class Confectionary : Goods, IProduct
    {
        public string Taste { get; set; }

        public Confectionary(int id, string taste) : base(id)
        {
            Taste = taste;
        }


    }
}
