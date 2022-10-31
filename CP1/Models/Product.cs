using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Product
    {
        internal double quatity;

        // atributos

        public int id { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        public double price { get; set; } // precio de venta
        public int quantity { get; set; } // unidades de producto
        public double cost { get; set; } // coste inicial
        public DateTime date { get; set; }

        // asociacion unidireccional
        public Manufacturer manufacturer { get; set; }

        // constructores
        public Product() { }

        //metodos
        // ToString
        
        public override string ToString()
        {
            return $"id: {id}, name:{name}, weight:{weight}, price:{price}, " +
                $"quantity:{quantity}, cost:{cost}, date{date}";
        }
    }
}
