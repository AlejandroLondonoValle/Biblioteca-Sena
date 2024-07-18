using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace POO.Models;
public class Functions
{
    public static List<Libro> libros = new List<Libro>
    {
        new Libro(1, "Obra Negra", new DateOnly(2024, 1, 1), "Gonzalo Arango", "104356106540","Nadaismo",50.000),
        new Libro(2, "Cien años de soledad", new DateOnly(1967, 5, 30), "Gabriel García Márquez", "9781400034685", "Realismo mágico", 120.50),
        new Libro(3, "Ficciones", new DateOnly(1944, 6, 1), "Jorge Luis Borges", "9788466320412", "Ficción", 75.80),
        new Libro(4, "La ciudad y los perros", new DateOnly(1963, 1, 1), "Mario Vargas Llosa", "9788433926416", "Novela", 90.25),
        new Libro(5, "Rayuela", new DateOnly(1963, 1, 1), "Julio Cortázar", "9780307474722", "Realismo mágico", 85.30),
        new Libro(6, "La casa de los espíritus", new DateOnly(1982, 1, 1), "Isabel Allende", "9781101971065", "Realismo mágico", 110.00),
        new Libro(7, "Veinte poemas de amor y una canción desesperada", new DateOnly(1924, 1, 1), "Pablo Neruda", "9780307593255", "Poesía", 55.60),
        new Libro(8, "El laberinto de la soledad", new DateOnly(1950, 1, 1), "Octavio Paz", "9789681665414", "Ensayo", 65.75),
        new Libro(9, "La región más transparente", new DateOnly(1958, 1, 1), "Carlos Fuentes", "9786071632712", "Ficción", 95.20),
        new Libro(10, "Versos sencillos", new DateOnly(1891, 1, 1), "Jose Marti", "9781530419520", "Poesía", 50.30),
        new Libro(11, "Aura", new DateOnly(1962, 1, 1), "Carlos Fuentes", "9789681665957", "Ficción", 80.00),
        new Libro(12, "Fahrenheit 451", new DateOnly(1953, 1, 1), "Ray Bradbury", "9780307474722", "Ciencia ficción", 70.50),
        new Libro(13, "Crónica de una muerte anunciada", new DateOnly(1981, 1, 1), "Gabriel García Márquez", "9781400034685", "Realismo mágico", 95.20),
        new Libro(14, "Los detectives salvajes", new DateOnly(1998, 1, 1), "Roberto Bolaño", "9788433966993", "Ficción", 110.00),
        new Libro(15, "Pedro Páramo", new DateOnly(1955, 1, 1), "Juan Rulfo", "9786070103754", "Realismo mágico", 60.80),
        new Libro(16, "El Aleph", new DateOnly(1949, 1, 1), "Jorge Luis Borges", "9788426417217", "Ficción", 85.30),
        new Libro(17, "La sombra del viento", new DateOnly(2001, 1, 1), "Carlos Ruiz Zafón", "9788408056857", "Ficción", 95.00),
        new Libro(18, "Crónicas marcianas", new DateOnly(1950, 1, 1), "Ray Bradbury", "9788445076735", "Ciencia ficción", 75.40),
        new Libro(19, "El túnel", new DateOnly(1948, 1, 1), "Ernesto Sabato", "9788432211654", "Ficción", 70.90),
        new Libro(20, "Los hombres que no amaban a las mujeres", new DateOnly(2005, 1, 1), "Stieg Larsson", "9788466332514", "Novela negra", 85.60)
    };

    // Contador para generar IDs únicos para los libros
    static int contadorId = 21;


    public static void AñadirLibro()
    {
        // Añadir un nuevo libro a la lista
        Console.Write("Ingrese el Titulo del libro: ");
        string? titulo;
        while (string.IsNullOrWhiteSpace(titulo = Console.ReadLine()))
        {
            Console.WriteLine("El Titulo del libro no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }
        Console.Write("Ingrese la fecha de Publicacion (yyyy/MM/dd): ");
        DateOnly fechaDePublicacion;
        if (!DateOnly.TryParseExact(Console.ReadLine(), "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out fechaDePublicacion))
        {
            Console.WriteLine("Formato de fecha inválido. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }
        Console.Write("Ingrese el nombre del autor: ");
        string? autor;
        while (string.IsNullOrWhiteSpace(autor = Console.ReadLine()))
        {
            Console.WriteLine("El nombre del autor no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }
        Console.Write("Ingrese el ISBN (International Standard Book Number): ");
        string? isbn;
        while (string.IsNullOrWhiteSpace(isbn = Console.ReadLine()))
        {
            Console.WriteLine("El ISBN no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }
        Console.Write("Ingrese el Genero del libro: ");
        string? genero;
        while (string.IsNullOrWhiteSpace(genero = Console.ReadLine()))
        {
            Console.WriteLine("El Genero no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }
        Console.Write("Ingrese el valor del libro: ");
        double precio;
        if (!double.TryParse(Console.ReadLine(), out precio))
        {
            Console.WriteLine("Valor inválido. Intente de nuevo.");
            Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
            return;
        }

        Libro libro = new Libro(contadorId++, titulo, fechaDePublicacion, autor, isbn, genero, precio);

        libros.Add(libro);
        Console.WriteLine($"LA VENTA HA SIDO REGISTRADA CON EXITO!.");
        Console.WriteLine($"Id de la venta: {libro.Id}");
        Console.WriteLine();
        Thread.Sleep(3000); // Espera 3 segundos antes de volver al menú
    }
    public static void ClasificacionDeLibros()
    {
        var librosOrdenados = libros.OrderByDescending(v => v.FechaPublicacion).ToList();
        Console.WriteLine("Libros Ordenados por la fecha de publicacion:");
        string estado;

        // Obtener la fecha actual
        DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Today);

        // Restar 5 años a la fecha actual
        DateOnly fechaMenos5Anios = fechaActual.AddYears(-5);
        foreach (var libro in librosOrdenados)
        {
            if (libro.FechaPublicacion >= fechaMenos5Anios)
            {
                estado = "Reciente";
            }else
            {
                estado = "Antiguo";
            }
            Console.WriteLine($"Id: {libro.Id} | Titulo : {libro.Titulo} | Autor: {libro.Autor} | Fecha de publicacion: {libro.FechaPublicacion} | Estado: {estado}");
            Thread.Sleep(200); // Espera 200 milisegundos antes de volver al menú
        }
        Thread.Sleep(6000); // Espera 6 segundos antes de volver al menú
    }
}