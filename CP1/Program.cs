
using CP1.Repositories;
using CP1.Models;
using System;
using Msg = System.Console;

// 1. Crear objetos repositorio

// 2. Menú de opciones interactivo que se repita todo el tiempo

// Gestionar excepciones si ocurren

// Si se selecciona la opción Salir entonces se rompe el bucle y se termina el programa


public class Programa
{
    //private static int id;
    public static void Main()
    {
        IProductRepository productRepo = new ProductListRepository();

        while (true)
        {
            Msg.WriteLine("ELIGE UNA OPCION DEL MENU");
            Msg.WriteLine("-------------------------");
            Msg.WriteLine("1- Encontrar producto por id");
            Msg.WriteLine("2- Encontrar todos los productos");
            Msg.WriteLine("3- Encontrar productos por rango de precios");
            Msg.WriteLine("4- Encontrar productos por fecha de creación anterior a la fecha introducida");
            Msg.WriteLine("5- Encontrar productos por nombre de fabricante");
            Msg.WriteLine("6- Guardar nuevo producto en la lista");
            Msg.WriteLine("7- Actualizar un producto, todos los atributos excepto id, fabricante y fecha");
            Msg.WriteLine("8- Borrar un producto por id");
            Msg.WriteLine("9- Borrar todos los productos");
            Msg.WriteLine("10- Calcular la suma de todos los precios");
            Msg.WriteLine("11- Calcular el beneficio bruto teniendo en cuenta precios y cantidades");
            Msg.WriteLine("12- Calcular el beneficio neto teniendo en cuenta precios y cantidades menos el coste");
            Msg.WriteLine("13- Obtener productos con el IVA añadido al precio");
            Msg.WriteLine("14- Salir");
            Msg.WriteLine("\nSeleccione una opcion");

            switch (Msg.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 1-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el valor del id del producto a encontrar");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Product product1 = productRepo.FindById(id);

                    if (product1 == null) {
                        Msg.WriteLine($"Product not found");
                    }

                    else {
                        Msg.WriteLine($"El producto a encontrar es {product1}");
                    } 
                    Main();
                    break;

                case "2":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 2-----");
                    Msg.WriteLine("\n");
                    productRepo.PrintAll();
                    Main();
                    break;

                case "3":
                    Console.Clear();
                    Msg.WriteLine("----Opcion3-----");
                    Msg.WriteLine("\n");
                    Main();
                    break;

                default:
                    Console.Clear();
                    Msg.WriteLine("Opcion errónea");
                    Msg.WriteLine("\n");
                    Main();
                    break;
            }

        }

    }

   
} 