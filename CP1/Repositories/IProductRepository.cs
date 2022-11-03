using CP1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public interface IProductRepository
    {
        //Declaración de métodos para Product:
        //Encontrar un producto por id (FindById)
        Product FindById(int id);

        //Encontrar todos los productos (FindAll)
        List<Product> FindAll();

        //Imprime todos los productos
        void PrintAll();

        //Encontrar productos por rango de precios
        List<Product> FindAllByPrice(double min, double max);

        //Encontrar productos por fecha de creación anterior a la
        //fecha pasada por parámetro
        List<Product> FindAllByEarlierDate(DateTime date);

        //Encontrar productos por nombre de fabricante
        List<Product> FindAllByManufacturer(string manufacturer);

        //Guardar nuevo producto en la lista
        
        //OP2: crear método FindMaxId que encuentre el id máximo de los productos,
        //usamos ese id + 1 como nuevo id para el nuevo producto.
        int FindMaxId();

        bool Save(Product product);

        // comprobar si existe por id
        bool ExistsById(int id);

        //Actualizar un producto existente (los atributos excepto el id y el fabricante)
        bool Update(Product product);

        //Borrar un producto por id
        bool DeleteById(int id);

        //Borrar todos los productos
        bool DeleteAll();

        //Cálculo de la suma total de los precios
        double SumAllPrices();

        //Cálculo del beneficio bruto teniendo en cuenta precios y cantidades
        double CalculateGrossProfit();

        //Cálculo del beneficio neto teniendo en cuenta precios y cantidades menos coste
        double CalculateNetProfit();

        // Obtener los productos pero con el IVA añadido al precio.
        // El IVA será un número entero que reciba por parámetro
        // (por defecto valdrá 21) y será entre 1 y 100 (validar que no exceda estos rangos,
        // si excede los rangos dejamos el valor por defecto o lanzamos una excepción),
        // que tendremos que convertir a porcentaje (dividir entre 100) antes de usarlo.
        // Cuidado: el precio se modifica para los productos que devolvemos, pero no en la lista original.
        List<Product> FindAllIVAPriceProducts(int num);

    }


}
