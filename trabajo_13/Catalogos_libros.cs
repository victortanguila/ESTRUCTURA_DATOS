using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear catálogo de libros con un solo título en un HashSet
        HashSet<string> catalogoLibros = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "El Principito"
        };

        while (true)
        {
            Console.WriteLine("\n--- Catálogo de Libros ---");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Mostrar todos los títulos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "3")
                break;
            else if (opcion == "1")
            {
                Console.Write("Ingrese el título a buscar: ");
                string titulo = Console.ReadLine();
                Console.WriteLine(catalogoLibros.Contains(titulo) ? "Encontrado" : "No encontrado");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("\nLista de libros en el catálogo:");
                foreach (var libro in catalogoLibros)
                {
                    Console.WriteLine("- " + libro);
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}
