using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models
{
    // atributos
    public class Product
    {
        public int id;
        public string name { get; set; }
        public float weight { get; set; }
        public float price { get; set; } // precio de venta
        
        public int quantity { get; set; } // unidades de producto
        
        public float cost { get; set; } // coste inicial
        
        public DateTime date { get; set; }

        // asociaciones unidireccional
        public Manufacturer manufacturer { get; set; }

        // constructores
        public Product() { }

        //metodos

        // ToString
    }

}
