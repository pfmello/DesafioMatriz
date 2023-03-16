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

            int linha = "Insira o número de LINHAS da matriz:".ReturnInt();
            int coluna = "Insira o número de COLUNAS da matriz:".ReturnInt();
            int[,] matriz = new int[linha, coluna];

            PreencherMatriz(linha, coluna, matriz);

            PercorrerMatriz(matriz, coluna);


            Console.ReadLine();
        }

        private static void PreencherMatriz(int linha, int coluna, int[,] matriz)
        {

            string numeros = "10 8 15 12 21 11 23 8 14 5 13 19 8";
            string[] vetor = numeros.Split(' ');
            int indexVetor = 0;

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(vetor[indexVetor]);
                    indexVetor++;
                }
            }
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
