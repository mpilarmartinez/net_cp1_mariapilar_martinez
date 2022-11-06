using CP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public class ManufacturerListRepository : IManufacturerRepository
    
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

        public void AddManufacturer(Manufacturer manufacturer)
        {
            manufacturers.Add(manufacturer);
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

        public int FindMaxId()
        {
            int idmax = 1;

            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.id >= idmax)
                {
                    idmax = manufacturer.id;
                }
            }
            return idmax+1;
        }

        public bool Save(Manufacturer manufacturer)
        {
            int numElementosInicial = manufacturers.Count;
            int numElementosFinal;

            manufacturer.id = FindMaxId();

            manufacturers.Add(manufacturer);

            numElementosFinal = manufacturers.Count;

            if (numElementosInicial < numElementosFinal)
            {
                return true;
            }

            return false;
        }

        public bool ExistsById(int id)
        {

            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.id == id)
                    return true;
            }

            return false;
        }

        public bool ExistsByName(string name)
        {

            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.name == name)
                    return true;
            }

            return false;
        }

        public bool Update(Manufacturer manufacturer)
        {
            // comprobar si existe 
            if (!ExistsById(manufacturer.id))
                return false; // si no existe no lo podemos modificar

            for (int i = 0; i < manufacturers.Count; i++)
            {

                if (manufacturers[i].id == manufacturer.id)
                {
                    // actualizar atributos del fabricante de la lista con los
                    // del fabricante que llega como parámetro

                    manufacturers[i].id = manufacturer.id;
                    manufacturers[i].name = manufacturer.name;
                    
                    return true; // una vez modificado salimos del método
                }
            }
            return false;

        }

        public bool DeleteById(int id)
        {

            // comprobar si existe 
            if (!ExistsById(id))
                return false; // si no existe no lo podemos borrar

            for (int i = 0; i < manufacturers.Count; i++)
            {

                if (manufacturers[i].id == id)
                {
                    manufacturers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

}
