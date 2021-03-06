﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_WHILE
    {
        public static void Executar()
        {
            int palpite = 0;
            Random aleatorio = new Random();

            int numeroSecreto = aleatorio.Next(1, 16); // Número aleatório entre 1 e 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

           //Estrutura while
            while (tentativasRestantes > 0 && !numeroEncontrado){
                Console.Write("Insira o seu Palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green; 
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente Novamente!");
                    Console.WriteLine("Tentativas restantes: {0}",tentativasRestantes);
                }
                else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
            Console.WriteLine("Fim do jogo. Muito obrigado por jogar!");

        }
    }
}
