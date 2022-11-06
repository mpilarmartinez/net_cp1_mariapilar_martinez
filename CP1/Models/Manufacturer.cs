using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Models
{
    
    public class Manufacturer
    {
        // atributos
        public int id { get; set; }
        public string name { get; set; }

        // constructores
        public Manufacturer() { }

        //metodos

        // ToString
        public override string ToString()
        {
            return $"id: {id}, name:{name}";
        }

    }

}
