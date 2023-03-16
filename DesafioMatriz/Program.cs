using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            "Desafio De Fixação Matriz !".Print();

            int M = "Insira o número de LINHAS da matriz:".ReturnInt();
            int N = "Insira o número de COLUNAS da matriz:".ReturnInt();

            int[,] matriz = new int[M, N];

            PercorrerMatriz(matriz, N);


            Console.ReadLine();
        }

        private static void PercorrerMatriz(int[,] matriz, int N)
        {
            int contador = 0;
            foreach (int numero in matriz)
            {

                Console.Write(numero + " ");
                contador++;
                if (contador == N)
                {
                    Console.WriteLine();
                    contador = 0;
                }
            }
        }
    }

    public static class ConsoleHelper
    {
        public static void Print(this string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static int ReturnInt(this string mensagem)
        {
            bool numeroValido;
            int numero;
            mensagem.Print();

            do
            {
                string output = Console.ReadLine();
                numeroValido = int.TryParse(output, out numero); 
            } while (!numeroValido);

            return numero;
        }
    }
}
