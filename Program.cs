using System;

namespace Velocidade_Media
{
    class Program
    {
        static void Main(string[] args)
        {



            double tempo;
            double distancia;
            double velocidade;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---- Exercício Velocidade Média ----");
            Console.WriteLine("Cálculo da velocidade, a partir da distância (em metros) e do tempo (em segundos).");
            Console.WriteLine();

            Console.Write(" - Insira a distância percorrida (m): ");
            distancia = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine();


            Console.Write(" - Insira o tempo gasto (s): ");
            tempo = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine();

            velocidade = distancia/tempo;

            Console.WriteLine($" - Velocidade Média: {Math.Floor(velocidade)} m/s.");



            








        }
    }
}
