﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Excecoes {

    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas {

        public static int PositivoPar() {
            Random randon = new Random();
            int valor = randon.Next(-30, 30);

            if(valor < 0) {
                throw new NegativoException("Número Negativo!");
            }

            if(valor % 2 == 1) {
                throw new ImparException("Valor Impar..");
            }

            return valor;

        }

        public static void Executar() {
            int c = 0;
            do {
                try {
                    Console.WriteLine(PositivoPar());
                } catch (NegativoException ex) {
                    Console.WriteLine(ex.Message);
                } catch (ImparException ex) {
                    Console.WriteLine(ex.Message);
                }
                c++;
            } while (c <= 10);
        }
    }
}
