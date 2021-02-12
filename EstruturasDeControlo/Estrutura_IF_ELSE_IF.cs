﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_IF_ELSE_IF
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else {
                if (nota >= 7.0 && nota < 9.0){
                    Console.WriteLine("Aprovado!");
                }
            }
        }
    }
}
