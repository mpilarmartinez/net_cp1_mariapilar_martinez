
using CP1.Repositories;
using CP1.Models;
using System;
using System.IO;
using Msg = System.Console;

// 1. Crear objetos repositorio

// 2. Menú de opciones interactivo que se repita todo el tiempo

// Gestionar excepciones si ocurren

// Si se selecciona la opción Salir entonces se rompe el bucle y se termina el programa


public class Programa
{
    private static object ex;

    //private static int id;
    public static void Main()
    {
        IProductRepository productRepo = new ProductListRepository();
        IManufacturerRepository manufacturerRepo = new ManufacturerListRepository();
        List<Product> productsAux;
        Manufacturer manufacturerAux;
        int id;
        Product productAux = new Product();
        Manufacturer ManufacturerAux = new Manufacturer();
        string opcion = "1";

        while (opcion != "14")
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

            opcion = Msg.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 1-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el valor del id del producto a encontrar");
                    
                    id = Convert.ToInt32(Console.ReadLine());
                    productAux = productRepo.FindById(id);

                    if (productAux == null)
                    {
                        Msg.WriteLine($"Product not found");
                    }

                    else
                    {
                        Msg.WriteLine($"El producto a encontrar es {productAux}");
                    }
                    Msg.WriteLine("\n");
                    break;

                case "2":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 2-----");
                    Msg.WriteLine("\n");
                    productRepo.PrintAll();
                    Msg.WriteLine("\n");
                    break;

                case "3":
                    Console.Clear();
                    Msg.WriteLine("----Opcion3-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el valor minimo del rango de precios");
                    double min = Convert.ToDouble(Console.ReadLine());
                    Msg.WriteLine("Introduce el valor máximo del rango de precios");
                    double max = Convert.ToDouble(Console.ReadLine());
                    productsAux = productRepo.FindAllByPrice(min, max);
                    Msg.WriteLine($"Los productos por rango son: ");
                    foreach (Product product in productsAux)
                    {
                        Console.WriteLine(product);
                        Msg.WriteLine("\n");
                    }
                    Msg.WriteLine("\n");
                    break;

                case "4":
                    Console.Clear();
                    Msg.WriteLine("----Opcion4-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el anyo");
                    int anyo = Convert.ToInt32(Console.ReadLine());
                    Msg.WriteLine("Introduce el mes");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Msg.WriteLine("Introduce el día");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    DateTime NuevaFecha = new DateTime(anyo, mes, dia);
                    productsAux = productRepo.FindAllByEarlierDate(NuevaFecha);
                    Msg.WriteLine($"Los fechas anteriores son: ");
                    foreach (Product product in productsAux)
                    {
                        Console.WriteLine(product);
                        Msg.WriteLine("\n");
                    }
                    Msg.WriteLine("\n");
                    break;

                case "5":
                    Console.Clear();
                    Msg.WriteLine("----Opcion5-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el nombre del fabricante");
                    string manufacturer = (Console.ReadLine());
                    productsAux = productRepo.FindAllByManufacturer(manufacturer);
                    Msg.WriteLine($"Los productos con el  nombre del fabricante introducido son: ");
                    foreach (Product product in productsAux)
                    {
                        Console.WriteLine(product);
                        Msg.WriteLine("\n");
                    }
                    Msg.WriteLine("\n");
                    break;

                case "6":
                    Console.Clear();
                    Msg.WriteLine("----Opcion6-----");
                    Msg.WriteLine("\n");

                    Msg.WriteLine("Introduce el nombre del fabricante");
                    string name = (Console.ReadLine());

                    bool ExisteManufacturer = manufacturerRepo.ExistsByName(name);
                    if (ExisteManufacturer)
                    {
                        Msg.WriteLine("El fabricante ya existe.");

                    }
                    else
                    {
                        int i = manufacturerRepo.FindMaxId();
                        Msg.WriteLine($"El nuevo fabricante tiene indice {i}");
                        manufacturerAux = new Manufacturer { id = i, name = name };
                        manufacturerRepo.AddManufacturer(ManufacturerAux);
                    };
                        Msg.WriteLine("\n");

                        int id_product = productRepo.FindMaxId();

                        Msg.WriteLine("Introduce el nombre del producto");
                        string nombre = (Console.ReadLine());

                        Msg.WriteLine("Introduce el peso del producto");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Msg.WriteLine("Introduce el precio del producto");
                        double precio = Convert.ToDouble(Console.ReadLine());

                        Msg.WriteLine("Introduce la catidad de productos");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        Msg.WriteLine("Introduce el coste del producto");
                        double coste = Convert.ToDouble(Console.ReadLine());

                        Msg.WriteLine("Introduce el anyo");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Msg.WriteLine("Introduce el mes");
                        int month = Convert.ToInt32(Console.ReadLine());

                        Msg.WriteLine("Introduce el día");
                        int day = Convert.ToInt32(Console.ReadLine());
                        DateTime Fecha = new DateTime(year, month, day);

                        productAux.id = id_product;
                        productAux.name = nombre;
                        productAux.weight = peso;
                        productAux.price = precio;
                        productAux.quantity = cantidad;
                        productAux.cost = coste;
                        productAux.date = Fecha;
                        productAux.manufacturer = ManufacturerAux;

                        bool saved = productRepo.Save(productAux);

                        if (saved)
                        {
                            Console.WriteLine("Se guardó correctamente el producto");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo guardar el producto");
                        }
                    Msg.WriteLine("\n");
                    break;

                 case "7":
                    Console.Clear();
                    Msg.WriteLine("----Opcion7-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el valor del id del producto a actualizar");
                    id = Convert.ToInt32(Console.ReadLine());

                    Msg.WriteLine("Introduce el nuevo nombre del producto");
                    string nombre7 = Console.ReadLine();
                    Msg.WriteLine("Introduce el nuevo peso del producto");
                    double peso7 = Convert.ToDouble(Console.ReadLine());
                    Msg.WriteLine("Introduce el nuevo precio del producto");
                    double precio7 = Convert.ToDouble(Console.ReadLine());
                    Msg.WriteLine("Introduce la nueva catidad de productos");
                    int cantidad7 = Convert.ToInt32(Console.ReadLine());
                    Msg.WriteLine("Introduce el nuevo coste del producto");
                    double coste7 = Convert.ToDouble(Console.ReadLine());

                    productAux.id = id;
                    productAux.name = nombre7;
                    productAux.weight = peso7;
                    productAux.price = precio7;
                    productAux.quantity = cantidad7;
                    productAux.cost = coste7;

                    Msg.WriteLine("\n");

                    bool isModified = productRepo.Update(productAux);
                    if (isModified)
                    {
                        Console.WriteLine("Se ha modificado el producto");
                    } else
                    {
                        Console.WriteLine("Error en la actualización del producto");
                    }
                    Msg.WriteLine("\n");
                    break;

                 case "8":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 8-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el id del producto a borrar");
                    int id_pro = Convert.ToInt32(Console.ReadLine());
                    if (productRepo.FindById(id_pro) == null)
                    {
                        Msg.WriteLine("El Id introducido no existe");
                    }
                    else
                    {
                        bool isDeleted = productRepo.DeleteById(id_pro);
                        if (isDeleted) Console.WriteLine($"Se ha eliminado el ordenador con Id {id_pro}");
                    }
                    Msg.WriteLine("\n");
                    break;

                case "9":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 9-----");
                    Msg.WriteLine("\n");
                    bool hasDeletedAll = productRepo.DeleteAll();
                    if (hasDeletedAll) Console.WriteLine("Se han eliminado todos los productos");
                    Msg.WriteLine("\n");
                    break;

                case "10":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 10-----");
                    Msg.WriteLine("\n");
                    double sumaprecios = productRepo.SumAllPrices();
                  
                    Console.WriteLine($"La suma de todos los  precios de los productos es {sumaprecios}");
                    Msg.WriteLine("\n");
                    break;

                case "11":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 11-----");
                    Msg.WriteLine("\n");
                    double beneficiobruto = productRepo.CalculateGrossProfit();
                    Console.WriteLine($"El beneficio bruto teniendo en cuenta precios y cantidades es {beneficiobruto}");
                    Msg.WriteLine("\n");
                    break;

                case "12":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 12-----");
                    Msg.WriteLine("\n");
                    double beneficioneto = productRepo.CalculateNetProfit();
                    Console.WriteLine($"El beneficio bruto teniendo en cuenta precios y cantidades menos el coste es {beneficioneto}");
                    Msg.WriteLine("\n");
                    break;

                case "13":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 13-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Introduce el valore del IVA");
                    int IVA = Convert.ToInt32(Console.ReadLine());
                    List<Product> products13 = productRepo.FindAllIVAPriceProducts(IVA);
                   
                    Msg.WriteLine($"Los precios de productos con el IVA  son: ");
                    foreach (Product product in products13)
                    {
                        Console.WriteLine(product);
                        Msg.WriteLine("\n");
                    }
                    Msg.WriteLine("\n");                
                    break;

                case "14":
                    Console.Clear();
                    Msg.WriteLine("----Opcion 14 Salir-----");
                    Msg.WriteLine("\n");
                    Msg.WriteLine("Hasta pronto");
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