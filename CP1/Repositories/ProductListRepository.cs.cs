﻿using CP1.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Msg = System.Console;

namespace CP1.Repositories
{
    public class ProductListRepository : IProductRepository
    {

        //atributo lista de productos 
        private List<Product> products;
        private object product;
        private int id;

        // Constructor
        public ProductListRepository()
        {
            DateTime date1 = new DateTime(2022, 01, 01);
            DateTime date2 = new DateTime(2022, 03, 01);
            Manufacturer manufacturer = new Manufacturer { id = 1, name = "manufacturer1" };
            Manufacturer manufacturer1 = new Manufacturer { id = 2, name = "manufacturer2" };


            products = new List<Product> {
            new Product{ id = 1, name = "producto1", weight = 35.5, price = 25.5, quantity = 5, cost = 20.5, date = date1, manufacturer = manufacturer},
            new Product{ id = 2, name = "producto2", weight = 32.3,  price = 20.5, quantity = 8, cost = 15.5, date =date2, manufacturer = manufacturer1},
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

        public int FindMaxId()
        {
            int idmax = 0;

            foreach (Product product in products)
            {
                if (product.id > idmax)
                {
                    idmax = product.id;
                }
            }
            return idmax++;
        }

        public bool Save(Product product)
        {
            int numElementosInicial = products.Count;
            int numElementosFinal;

            products.Add(product);

            numElementosFinal = products.Count;

            /*
             * Compruebo que se realiza la función
             * Para ello recorro la lista después de 
             * realizar la operación solicitada y así 
             * compruebo que se ha ejecutado correctamente
             */
            foreach (Product p in products)
            {
                Msg.WriteLine(p.name);
                Msg.WriteLine("\n");
            }

            if (numElementosInicial < numElementosFinal)
            {
                return true;
            }

            return false;
        }

        public bool ExistsById(int id)
        {

            foreach (Product product in products)
            {
                if (product.id == id)
                    return true;
            }

            return false;
        }

        public bool Update(Product product)
        {
            // comprobar si existe 
            if (!ExistsById(product.id))
                return false; // si no existe no lo podemos modificar

            for (int i = 0; i < products.Count; i++)
            {

                if (products[i].id == product.id)
                {
                    // actualizar atributos del product de la lista con los
                    // del product que llega como parámetro
                    products[i].name = product.name;
                    products[i].weight = product.weight;
                    products[i].price = product.price;
                    products[i].quantity = product.quantity;
                    products[i].cost = product.cost;

                    /*
                    * Compruebo que se realiza la función
                    * Para ello recorro la lista después de 
                    * realizar la operación solicitada y así 
                    * compruebo que se ha ejecutado correctamente
                    */

                    foreach (Product p in products)
                    {
                        Msg.WriteLine(p.name);
                        Msg.WriteLine("\n");
                    }

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

            for (int i = 0; i < products.Count; i++)
            {

                if (products[i].id == id)
                {
                    products.RemoveAt(i);
                    /*
                    * Compruebo que se realiza la función
                    * Para ello recorro la lista después de 
                    * realizar la operación solicitada y así 
                    * compruebo que se ha ejecutado correctamente
                    */
                    foreach (Product p in products)
                    {
                        Msg.WriteLine(p.name);
                        Msg.WriteLine("\n");
                    }
                    return true;
                }
            }
            return false;
        }

        public bool DeleteAll()
        {

            if (!products.Any())
                return false;

            products.Clear();

            /*
                * Compruebo que se realiza la función
                * Para ello recorro la lista después de 
                * realizar la operación solicitada y así 
                * compruebo que se ha ejecutado correctamente
                */
            foreach (Product p in products)
            {
                Msg.WriteLine(p.name);
                Msg.WriteLine("\n");
            }

            return true;
        }

        public double SumAllPrices()
        {
            double suma_precios = 0;

            foreach (Product product in products)
            {

                suma_precios = suma_precios + product.price;

            }
            return suma_precios;

        }

        public double CalculateGrossProfit()
        {
            double total = 0;

            foreach (Product product in products)
            {

                total = total + (product.price * Convert.ToDouble(product.quantity));
                

            }

            return total;
        }

        public double CalculateNetProfit()
        {

            double total1 = 0;
            double result = 0;

            foreach (Product product in products)
            {

                total1 = total1 + (product.cost * product.quantity); 
            }

            result = CalculateGrossProfit() - total1;
           

            return result;
        }

        // Obtener los productos pero con el IVA añadido al precio.
        // El IVA será un número entero que reciba por parámetro
        // (por defecto valdrá 21) y será entre 1 y 100 (validar que no exceda estos rangos,
        // si excede los rangos dejamos el valor por defecto o lanzamos una excepción),
        // que tendremos que convertir a porcentaje (dividir entre 100) antes de usarlo.
        // Cuidado: el precio se modifica para los productos que devolvemos, pero no en la lista original.

        public List<Product> FindAllIVAPriceProducts(int num)
        {

            List<Product> productsIVAPrice = new List<Product>();

            if (num < 1 || num > 100) num = 21;

            double porcentaje = Convert.ToDouble(num) / 100;

            productsIVAPrice = Clone();

            foreach (Product product in productsIVAPrice)
            {
                
                product.price = (product.price * (1 + porcentaje));
                
            }
            return productsIVAPrice;
        }

        private List<Product> Clone()
        {
            List<Product> clone = new List<Product>();
            foreach (Product product in products)
            {
                clone.Add((Product)product.Clone());
            }
            return clone;
        }


        public void PrintAll()
        {
            foreach (Product product in products)
                Console.WriteLine(product);
        }

        // Count
        public int Count()
        {
            int contador = 0;

            foreach (Product product in products)
            {
                contador++;
            }
            return contador;
        }

        List<Product> IProductRepository.Clone()
        {
            throw new NotImplementedException();
        }
    }
}