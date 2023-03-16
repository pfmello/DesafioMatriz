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

            int numero = "Qual numero voce quer saber informações ?".ReturnInt();

            AcharNumero(numero, linha, coluna, matriz);

            Console.ReadLine();
        }

        private static void AcharNumero(int numero, int linha, int coluna, int[,] matriz)
        {

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (numero == matriz[i,j])
                    {
                        Console.WriteLine($"Achei o {numero} na linha {i}, coluna {j}, posição {i},{j}!");

                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        }
                        if (j < linha - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Acima: {matriz[i - 1,j]}");
                        }

                        if (i < coluna -1)
                        {
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                        }

                        //Console.WriteLine($"Abaixo: {matriz[i +1,j]}");
                    }
                }
            }

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
}
