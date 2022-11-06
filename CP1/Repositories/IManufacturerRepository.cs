using CP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public interface IManufacturerRepository
    {
    //Declaración de métodos para Product:
    //Encontrar un manufacturer por id (FindById)
        Manufacturer FindById(int id);

        //Encontrar todos los fabricantes (FindAll)
        List<Manufacturer> FindAll();

        //Guardar nuevo fabricante en la lista
        //OP2: crear método FindMaxId que encuentre el id máximo de los fabricantes,
        //usamos ese id + 1 como nuevo id para el nuevo fabricante.
        int FindMaxId();

        bool Save(Manufacturer manufacturer);

        // comprobar si existe por id
        bool ExistsById(int id);

        // comprobar si existe por name
        bool ExistsByName(string name);

        //Actualizar fabricante
        bool Update(Manufacturer manufacturer);

        //Borrar fabricante por id
        bool DeleteById(int id);
        void Save();
        void AddManufacturer(Manufacturer nuevoManufacturer);
    }
}
