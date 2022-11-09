using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "SÃO PAULO");
            estados.Add("RJ", "RIO DE JANEIRO");
            estados.Add("PE", "PERNAMBUCO");
            estados.Add("MG", "MINAS GERAIS");

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} | Estado: {item.Value}");
            }
        }
    }
}
