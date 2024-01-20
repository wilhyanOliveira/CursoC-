using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        
        static void Main(string[] args)

        {
            #region numericas integrais 
            //Integra assinado
             sbyte num1 = 10; // 8 bits, de -128 a 127
             short num2 = 20; // 16 bits, de -32.768 a 32.767
             int num3 = 30; // 32 bits, -2.147.483.648 a 2.146.483.647
             long num4 = 40; // 63 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

             //Integral sem sinal
             byte num5 = 10; // 8 bits, intervalo de  0 a 255
             ushort num6 = 20; // 16 bits, de 0 a 65.535
             uint num7 = 30; //32 bits, de 0 a 4..294.967.295
             ulong num8 = 40; // 64 bits, de o a 18.446.744.074.709.551.615

             sbyte numero;
             numero = 100;

             Console.WriteLine(numero);
             Console.ReadKey(); // para esperar um click do usuário 

             // atribuir valor de outra variavel 

             numero = num1;
            #endregion

            #region Números Rais
            float real1 = 100f; //precisa do F - 32 bits 
            double real2 = 500.754; //64 bits 
            decimal real3 = 752538.457M; //Precisa do M quando declarada de forma literal----- 128 bits 

            double valor1;
            valor1 = real2;

            Console.WriteLine(valor1);
            Console.ReadKey();
            #endregion

            #region boolan - Verdadeiro ou Falso 

            bool verificar = false;
            verificar = true;

            #endregion

            #region caracteres 

            char letra = 'A'; //Apenas um caractere em aspas simples -- Permite caractere especiais

            //char letra = '\u0041';
            //char escape = '\nn'; --- quebra de linha
            //char literal = 'c';

            #endregion

            #region Tipo String

            string texto = "Wilhyan"; //Permite qualquer tipo de caractere
            string texto2 = "Wilhyan Anselmi de Oliveira \n 2002 \n 08320388902"; //considera caractere de escape
            string texto3 = @"Wilhyan Anselmi de Oliveira \n 2002 \n 08320388902"; // Com @ desconsidera caracteres de escape
            string mensagem = null;
            mensagem = texto;

            #endregion

            #region tipo Var
            //int    var varNum =0;
            //string var varText = "texto";
            //int[]  var varVetor = new[]{0,1,2,3};

            //variaveis tipo var não possuem tipo definido mas precisam de valor repassado
            //após atribuido o valor o tipo deve permanecer até o fim da execução

            var valor = 100;
            //var valor = "Wilhyan";

            #endregion Topo Object

            #region Tipo Object 

            // pode ser atribuido qualquer valor de dados em variaveis do tipo
            // é a base para as variaveis do C#
            // permite variação de valores 
            // todos os valores serão tratados como Objeto e não como o tipo da variavel 

            object obj = false;
            obj = 200;
            obj = "Wilhyan";

            #endregion

            #region Constantes

            //valores que não podem serem alteradas
            // o valor precisa ser definido na criação da variável 

            const double pi = 3.1415; // numero PI nunca muda, sendo uma constante
            const string nome = "Wilhyan";

            #endregion

            #region ENUM 


            #endregion
            Console.WriteLine(letra);
            Console.ReadKey();

        }



    }
}
