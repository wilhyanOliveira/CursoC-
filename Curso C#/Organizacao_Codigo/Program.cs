using System;

namespace Organizacao_Codigo
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            //Escreve as Cinco primeiras mensagens
            Console.WriteLine("Primeiro comando");
            Console.WriteLine("Segundo comando");
            Console.WriteLine("Terceiro comando");
            Console.WriteLine("Quarto comando");
            Console.WriteLine("quinto comando");

            //Escreve as cinco demais mensagens
            Console.WriteLine("Sexto comando");
            Console.WriteLine("Setimo comando");
            Console.WriteLine("Oitavo comando");
            Console.WriteLine("Nono comando");
            Console.WriteLine("Decimo comando");

            //Region

            #region Escreve as Cinco primeiras mensagens
            Console.WriteLine("Region 1");
            Console.WriteLine("Region 2");
            Console.WriteLine("Region 3");
            Console.WriteLine("Region 4");
            Console.WriteLine("Region 5");
            #endregion

            #region Escreve as cinco demais mensagens
            Console.WriteLine("Region 6");
            Console.WriteLine("Region 7");
            Console.WriteLine("Region 8");
            Console.WriteLine("Region 9");
            Console.WriteLine("Region 10");
            #endregion
        }

    }
}
