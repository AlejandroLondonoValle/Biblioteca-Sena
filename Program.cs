using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;


namespace POO.Models;
public class Program
{
static void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("                            BIBLIOTECA  SENA                             ");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("| {0,-1} | {1,-43} |", " No ", "                           Opción                             ");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(1) ", "Añadir Nuevo Libro                                            ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(2) ", "Clasificacion de lo Libros                                    ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(3) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(4) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(5) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(6) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(7) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-53} |", "(0) ", "                                                              ");
            Console.WriteLine("=========================================================================");
            Console.Write("Seleccione una opción del menú: ");
   
            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("UPS!! OPCION INVALIDA, INTENTE DE NUEVO...");
                Thread.Sleep(4000); // Espera 4 segundos antes de volver al menú
                continue;
            }

            

            Console.WriteLine();
        }
    }





}
