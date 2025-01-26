using System;
using System.Collections.Generic;

class Program
{
    static bool VerificarBalanceo(string formula)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in formula)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;

                char top = pila.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }
        return pila.Count == 0;
    }

    static void Main(string[] args)
    {
        string formula = "{7+(8*5)-[(9-7)+(4+1)]}";
        if (VerificarBalanceo(formula))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }
    }
}
