﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
   public class SubCelebridade {
        //Todos acedem publico
        public string InfoPublica = "Tenho Instagram!";

        // Herança , transmitido por herança
        protected string CorDoOlho = "Verde";

        //Mesmo projecto (assembly)
        internal ulong NumeroCelular = 5511999999999999;


        // herança ou no mesmo projecto
        protected internal string JeitoDeFalar = "uso muitas Girias";

        //mesma class ou herança no mesmo projeto
        private protected string SegredoDeFamilia = "Bla bla!";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeuAcessos() {
            Console.WriteLine("..: SubCelebrida :..");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}