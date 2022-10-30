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

        /*Guardar nuevo fabricante, replicar lo mismo para generar el id de fabricante que se hizo en productos.
        Actualizar fabricante
        Borrar fabricante por id
        */

    }
}
