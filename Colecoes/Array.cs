﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];//todos os dados são do mesmo tipo e um tamanho constante
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";
            //alunos[5] = "Emanuel"; // indicie fora do ambito

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 3.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("Média: {0}", media);

            somatorio = 0;
            for (int i = 0; i<5; i++) {
                somatorio += notas[i];
            }

            double media1 = somatorio / notas.Length;
            Console.WriteLine("Média: {0}", media1);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
            // ou //
            foreach (var letra in letras) {
                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
}
