﻿using System;
using CursoCsharp.ClassesEMetodos;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {

    public class Caixa<T> {
        T valorPrivado;
        
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { 
        }
    }

    class CaixaProduto : Caixa<Produto> {
        public CaixaProduto() : base(new Produto()) { 
        }
    }

    class GenericsExemplo {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            Console.WriteLine();
            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
