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
                    }
                }
            }

        }

        private static void PreencherMatriz(int linha, int coluna, int[,] matriz)
        {
            int numerosNecessarios = QuantosNumeros(matriz);
            string[] vetor = new string[numerosNecessarios];
            

            bool numerosSuficientes = false;
            do
            {
                Console.WriteLine($"A matriz precisa de {numerosNecessarios} numeros ! Coloque separados por espaço !");
                string numeros = Console.ReadLine();
                vetor = numeros.Split(' ');
                Console.WriteLine($"Voce inseriu {vetor.Length} numeros !");

                if (vetor.Length == numerosNecessarios)
                {
                    numerosSuficientes = true;

                    foreach (var valor in vetor)
                    {
                        bool numeroValido = false;
                        numeroValido = int.TryParse(valor, out int numeroTeste);

                        if(!numeroValido)
                        {
                            Console.WriteLine("Você inseriu valores inválidos ! Para de graça !");
                            numerosSuficientes = false;
                        }
                    }

                }
            } while (!numerosSuficientes);

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

        private static int QuantosNumeros(int[,] matriz)
        {
            int numeros = 0;

            foreach (int numero in matriz)
            {
                numeros++;
            }

            return numeros;
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
