using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Mensaje de inicio
        Console.WriteLine("=== Universidad Estatal Amazónica ===");
        Console.WriteLine("Simulación de Vacunación COVID-19\n");

        // Se crea un conjunto de 500 ciudadanos con identificadores únicos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Se crean conjuntos para almacenar vacunados con AstraZeneca y Pfizer
        HashSet<string> astrazeneca = new HashSet<string>();
        HashSet<string> pfizer = new HashSet<string>();

        //  Se seleccionan 100 ciudadanos aleatorios para AstraZeneca
        List<string> listaCiudadanos = ciudadanos.ToList();
        Random random = new Random();
        while (astrazeneca.Count < 100)
        {
            string seleccionado = listaCiudadanos[random.Next(listaCiudadanos.Count)];
            astrazeneca.Add(seleccionado);
        }

        //  Se seleccionan 50 ciudadanos aleatorios para Pfizer (sin repetir con AstraZeneca)
        while (pfizer.Count < 50)
        {
            string seleccionado = listaCiudadanos[random.Next(listaCiudadanos.Count)];
            if (!astrazeneca.Contains(seleccionado)) // Asegura que no se repita con AstraZeneca
            {
                pfizer.Add(seleccionado);
            }
        }

        // 🔹 Se identifican los ciudadanos que:
        HashSet<string> vacunadosAmbas = new HashSet<string>(astrazeneca.Intersect(pfizer)); // Recibieron ambas vacunas
        HashSet<string> soloPfizer = new HashSet<string>(pfizer.Except(astrazeneca)); // Solo Pfizer
        HashSet<string> soloAstraZeneca = new HashSet<string>(astrazeneca.Except(pfizer)); // Solo AstraZeneca
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(astrazeneca).Except(pfizer)); // No vacunados

        //  Mostrar los resultados
        MostrarResultados("Ciudadanos que NO se han vacunado", noVacunados);
        MostrarResultados("Ciudadanos que han recibido AMBAS vacunas (Pfizer y AstraZeneca)", vacunadosAmbas);
        MostrarResultados("Ciudadanos que SOLO han recibido la vacuna de Pfizer", soloPfizer);
        MostrarResultados("Ciudadanos que SOLO han recibido la vacuna de AstraZeneca", soloAstraZeneca);

        Console.WriteLine("\nProceso de simulación completado.");
    }

    // Método para mostrar los resultados en consola
    static void MostrarResultados(string titulo, HashSet<string> lista)
    {
        Console.WriteLine($"\n{titulo}: {lista.Count} personas");
        foreach (var ciudadano in lista)
        {
            Console.WriteLine($" - {ciudadano}");
        }
    }
}
