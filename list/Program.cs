using System;
using System.Collections.Generic;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Lista de Animais!");

            List<string> lista = new List<string>();

            lista.Add("Leao");
            lista.Add("Girafa");
            lista.Add("Elefante");
            lista.Add("Macaco");

            lista.Insert(1, "Coruja");

            lista.RemoveAt(4);

            foreach (string nome in lista)
            {
                Console.WriteLine($"Aqui etá o nome {nome}");
            }



        }
    }
}
