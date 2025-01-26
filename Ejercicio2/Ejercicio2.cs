<<<<<<< HEAD
﻿using System; // Importa el espacio de nombres System para utilizar funcionalidades básicas
using System.Collections.Generic; // Importa el espacio de nombres para utilizar listas genéricas

class Program
{
    static void Main(string[] args)
    {
        // Crea una lista de cadenas para almacenar las asignaturas
        List<string> asignaturas = new List<string>();

        // Agrega las asignaturas a la lista
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");

        // Muestra las asignaturas por pantalla
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas) // Itera sobre cada asignatura en la lista
        {
            Console.WriteLine(asignatura); // Imprime la asignatura actual
        }

        // Espera a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
=======
﻿using System; // Importa el espacio de nombres System para utilizar funcionalidades básicas
using System.Collections.Generic; // Importa el espacio de nombres para utilizar listas genéricas

class Program
{
    static void Main(string[] args)
    {
        // Crea una lista de cadenas para almacenar las asignaturas
        List<string> asignaturas = new List<string>();

        // Agrega las asignaturas a la lista
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");

        // Muestra las asignaturas por pantalla
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas) // Itera sobre cada asignatura en la lista
        {
            Console.WriteLine(asignatura); // Imprime la asignatura actual
        }

        // Espera a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
>>>>>>> 3f4ab64af452bd2aa4881b45ad94223f9e634223
}