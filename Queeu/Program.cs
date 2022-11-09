using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Queeu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            foreach(int filas in fila)
            {
                 Console.WriteLine(filas);
            }

            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} ");
            fila.Enqueue(10);

            foreach(int filas in fila)
            {
                 Console.WriteLine(filas);
            } 

        }
    }
}
