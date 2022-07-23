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
            Console.WriteLine("Hello World Fila !!!");

            Queue<Pessoa> pessoas = new();

            pessoas.Enqueue(new Pessoa("Reynald"));
            pessoas.Enqueue(new Pessoa("Reinaldo"));
            pessoas.Enqueue(new Pessoa("Renan"));
            pessoas.Enqueue(new Pessoa("Dulce"));
            pessoas.Enqueue(new Pessoa("Karol"));

            Console.WriteLine($"O primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"O número de pessoa na fila é : {pessoas.Count()}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

            }

        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return $"Nome: {Nome}";
            }


        }
    }
}
