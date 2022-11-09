using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(10);
            pilha.Push(20);
            pilha.Push(30);
            pilha.Push(40);
            pilha.Push(50);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo do topo {pilha.Pop()}");

            pilha.Push(80);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
