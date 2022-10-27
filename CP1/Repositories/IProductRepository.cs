﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public interface IProductRepository
    {
    /*declaración de métodos para Product

    Encontrar producto por id (FindById)

    Encontrar todos los productos (FindAll)
    Encontrar productos por rango de precios
    Encontrar productos por fecha de creación anterior a la fecha pasada por parámetro
    Encontrar productos por nombre de fabricante
    Guardar nuevo producto en la lista.
    Opción 1 para generar ID: El id no se le enviará dentro del objeto, se tiene que autogenerar. Para ello, la clase que implemente la interfaz tendrá un atributo NextProductId que inicialmente valdrá 1 y que cada vez que se agregue un producto nuevo se incrementará en 1. De esta forma cada vez que se agrega un nuevo producto se utiliza el id y después se incrementa. Esta variable no se decrementará en ningún momento, no se podrá consultar ni modificar desde fuera de la clase.
    Opción 2 para generar el ID: crear un método FindMaxId que encuentre el id máximo de los productos, entonces usamos ese id + 1 como nuevo id para el nuevo producto.
    Actualizar un producto existente: se actualizan todos los atributos menos el id y el fabricante
    Borrar un producto por id
    Borrar todos los productos
    Calcular la suma total de los precios
    Calcular el beneficio bruto teniendo en cuenta precios y cantidades
    Calcular beneficio neto teniendo en cuenta precios y cantidades menos coste
    Obtener los productos pero con el IVA añadido al precio. El IVA será un número entero que reciba por parámetro (por defecto valdrá 21) y será entre 1 y 100 (validar que no exceda estos rangos, si excede los rangos dejamos el valor por defecto o lanzamos una excepción), que tendremos que convertir a porcentaje (dividir entre 100) antes de usarlo. Cuidado: el precio se modifica para los productos que devolvemos, pero no en la lista original.

    Crear una clase que implemente la interfaz creada y proporcione el cuerpo de cada método declarado en la interfaz. La clase tendrá un atributo lista de productos sobre la que realizará las operaciones implementadas.
    
        */
        }
}
