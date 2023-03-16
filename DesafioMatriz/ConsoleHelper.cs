using System;

namespace DesafioMatriz
{
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
