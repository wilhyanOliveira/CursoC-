﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome1;
            string nome2;
            string nome3;
            string nome4;
            string auxiliar;

            Console.Write("Digite o nome #1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome #2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome #4: ");
            nome4 = Console.ReadLine();

            // mecanismo para inverter os nomes 

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

            Console.WriteLine("");
            Console.WriteLine("Nomes inseridos na sequncia invertida ");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();
        }
    }
}
