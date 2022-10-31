
using CP1.Repositories;
using System;
using Msg = System.Console;

// 1. Crear objetos repositorio

// 2. Menú de opciones interactivo que se repita todo el tiempo

// Gestionar excepciones si ocurren

// Si se selecciona la opción Salir entonces se rompe el bucle y se termina el programa


IProductRepository productRepo = new ProductListRepository();

public class Programa
{
    private static int id;

    public static void Main()
    {
        Msg.WriteLine("ELIGE UNA OPCION DEL MENU");
        Msg.WriteLine("-----------");
        Msg.WriteLine("1) Opcion 1: Encontrar producto por id");
        Msg.WriteLine("2) Opcion 2: ");
        Msg.WriteLine("3) Salir 3");
        Msg.WriteLine("\nSeleccione una opcion");
        switch (Msg.ReadLine())
        {
            case "1":
                Console.Clear();
                Msg.WriteLine("----Opcion 1-----");
                Msg.WriteLine("\n");
                Msg.WriteLine("Introduce el valor del id del producto a encontrar");
                id = Convert.ToInt32(Console.ReadLine());
                Main();
                break;

            case "2":
                Console.Clear();
                Msg.WriteLine("----Opcion 2-----");
                Msg.WriteLine("\n");
                Main();
                break;

            case "3":
                Console.Clear();
                Msg.WriteLine("----Opcion Salir-----");
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