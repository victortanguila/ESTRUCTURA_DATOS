using System;

// Clase que define un nodo del árbol binario
class Nodo
{
    public int Dato; // Dato almacenado
    public Nodo Izq, Der; // Referencias a los nodos hijos

    // Constructor que inicializa un nodo con un valor dado
    public Nodo(int dato)
    {
        Dato = dato;
        Izq = Der = null; // No tiene hijos al inicio
    }
}

// Clase que representa un Árbol Binario de Búsqueda
class ArbolBinario
{
    private Nodo raiz; // Nodo raíz del árbol

    // Método público para agregar valores
    public void Agregar(int dato)
    {
        raiz = Insertar(raiz, dato);
    }

    // Método privado recursivo para insertar un nodo en la posición correcta
    private Nodo Insertar(Nodo nodo, int dato)
    {
        if (nodo == null) // Si el nodo está vacío, se crea uno nuevo
            return new Nodo(dato);

        if (dato < nodo.Dato) // Si el valor es menor, va a la izquierda
            nodo.Izq = Insertar(nodo.Izq, dato);
        else // Si el valor es mayor, va a la derecha
            nodo.Der = Insertar(nodo.Der, dato);

        return nodo; // Se devuelve el nodo actualizado
    }

    // Método público para buscar un valor en el árbol
    public bool Contiene(int dato)
    {
        return Buscar(raiz, dato);
    }

    // Método recursivo para encontrar un valor
    private bool Buscar(Nodo nodo, int dato)
    {
        if (nodo == null) return false; // No se encontró el valor
        if (nodo.Dato == dato) return true; // Valor encontrado

        return dato < nodo.Dato ? Buscar(nodo.Izq, dato) : Buscar(nodo.Der, dato);
    }

    // Método público para recorrer el árbol en orden ascendente
    public void RecorrerInOrden()
    {
        InOrden(raiz);
        Console.WriteLine(); // Salto de línea tras el recorrido
    }

    // Método privado para el recorrido inorden
    private void InOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.Izq); // Recorre el subárbol izquierdo
            Console.Write(nodo.Dato + " "); // Imprime el valor actual
            InOrden(nodo.Der); // Recorre el subárbol derecho
        }
    }

    // Método público para eliminar un nodo
    public void Eliminar(int dato)
    {
        raiz = Remover(raiz, dato);
    }

    // Método recursivo para eliminar un nodo
    private Nodo Remover(Nodo nodo, int dato)
    {
        if (nodo == null) return nodo;

        if (dato < nodo.Dato)
            nodo.Izq = Remover(nodo.Izq, dato);
        else if (dato > nodo.Dato)
            nodo.Der = Remover(nodo.Der, dato);
        else
        {
            if (nodo.Izq == null) return nodo.Der;
            else if (nodo.Der == null) return nodo.Izq;

            Nodo sucesor = EncontrarMin(nodo.Der);
            nodo.Dato = sucesor.Dato;
            nodo.Der = Remover(nodo.Der, sucesor.Dato);
        }
        return nodo;
    }

    // Método auxiliar para encontrar el menor valor de un subárbol
    private Nodo EncontrarMin(Nodo nodo)
    {
        while (nodo.Izq != null)
            nodo = nodo.Izq;
        return nodo;
    }
}

// Clase principal con menú interactivo
class Programa
{
    static void Main()
    {
        ArbolBinario miArbol = new ArbolBinario();
        bool ejecutando = true;

        while (ejecutando)
        {
            Console.WriteLine("\n===== Menú de Árbol Binario =====");
            Console.WriteLine("1 - Agregar un valor");
            Console.WriteLine("2 - Consultar un valor");
            Console.WriteLine("3 - Recorrer el árbol en orden");
            Console.WriteLine("4 - Borrar un valor");
            Console.WriteLine("5 - Salir");
            Console.Write(" seleccione una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Número a insertar: ");
                    miArbol.Agregar(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Número a buscar: ");
                    Console.WriteLine(miArbol.Contiene(int.Parse(Console.ReadLine())) ? "Encontrado" : "No encontrado");
                    break;
                case "3":
                    Console.Write("Recorrido en orden: ");
                    miArbol.RecorrerInOrden();
                    break;
                case "4":
                    Console.Write("Número a eliminar: ");
                    miArbol.Eliminar(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Número eliminado correctamente.");
                    break;
                case "5":
                    ejecutando = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }
}
