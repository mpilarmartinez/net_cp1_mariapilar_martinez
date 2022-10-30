using CP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public class ManufacturerListRepository
    {
        //atributo lista de productos 
        private List<Manufacturer> manufacturers;
        private object manufacturer;

        // Constructor
        public ManufacturerListRepository()
        {
            manufacturers = new List<Manufacturer> {
            new Manufacturer{ id = 1, name = "manufacturer1"},
            new Manufacturer{ id = 2, name = "manufacturer2"},
            };
        }


        // Implementa métodos para  objectos Manufacturer
        // Encuentra por id
        public Manufacturer FindById(int id)
        {
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.id == id)
                    return manufacturer;
            }
            return null;
        }

        // Encuentra todos los manufacturers
        public List<Manufacturer> FindAll()
        {
            return manufacturers;
        }
    }

}
