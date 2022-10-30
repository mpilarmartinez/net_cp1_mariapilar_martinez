using CP1.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1.Repositories
{
    public class ProductListRepository : IProductRepository
    {

        //atributo lista de productos 
        private List<Product> products;
        private object product;
        private int i;

        // Constructor
        public ProductListRepository()
        {
            products = new List<Product> {
            new Product{ id = 1, name = "producto1", weight = 35.5, price = 25.5, quantity = 5, cost = 20.5, /*date = (2022,01,01)*/ },
            new Product{ id = 2, name = "producto2", weight = 32.3,  price = 20.5, quantity = 8, cost = 15.5, /*date = (2022,02,01)*/ },
            };
        }

        // Implementa métodos para  objectos Product
        // Encuentra por id
        public Product FindById(int id)
        {
            foreach (Product product in products)
            {
                if (product.id == id)
                    return product;
            }
            return null;
        }

        // Encuentra todos los productos 
        public List<Product> FindAll()
        {
            return products;
        }

        // Encuentra productos por rango de precios
        public List<Product> FindAllByPrice(double min, double max)
        {
            List<Product> productsByPrice = new List<Product>();

            foreach (Product product in products)
            {
                if (product.price >= min && product.price <= max)
                {
                    // añado el producto que cumple los filtros de precio a la nueva lista
                    productsByPrice.Add(product);
                }
            }
            return productsByPrice;

        }

        // Encuentra productos por fecha de creación anterior a la
        //fecha pasada por parámetro
        public List<Product> FindAllByEarlierDate(DateTime date)
        {
            List<Product> productsByEarlierDate = new List<Product>();

            foreach (Product product in products)
            {
                if (product.date < date)
                {
                    // añado el producto que cumple los filtros de fecha anterior a la nueva lista
                    productsByEarlierDate.Add(product);
                }
            }
            return productsByEarlierDate;
        }

        //Encuentra productos por nombre de fabricante
        public List<Product> FindAllByManufacturer(string manufacturer)
        {
            List<Product> productsByManufacturer = new List<Product>();

            foreach (Product product in products)
            {
                if (product.manufacturer.name.Equals(manufacturer))
                {
                    productsByManufacturer.Add(product);
                }
            }
            return productsByManufacturer;
        }

        public int FindMaxId(List<Product> products)
        {
            int idmax = 0;

            foreach (Product product in products)
            {
                if (product.id > idmax)
                {
                    idmax = product.id;
                }
            }
            return idmax + 1;
        }

        /*public bool Save(Product product)
        {      
        Console.WriteLine(product);
        product.id = FindMaxId();
         
        lo añado a la lista y devuelvo true
        products.Add(product);
                return true;     
        }*/
    }
}
