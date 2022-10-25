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
        public string name;
        public float weight;
        public float price;
        public int quantity;
        public float cost;
        public DateTime date;
        
        // asociaciones unidireccional
        public Manufacturer manufacturer; 

        // constructores
        public Product() { }

        //metodos

        // ToString
    }

}
