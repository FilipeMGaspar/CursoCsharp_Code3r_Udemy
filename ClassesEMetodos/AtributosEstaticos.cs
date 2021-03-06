﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {

        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }

    }

    
  

    class AtributosEstaticos { 
        
        public static void Executar() {
            var probuto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.2,
            };

            Produto.Desconto = 0.5;//Aceder uma variavél estática

            Console.WriteLine("Preço com desconto: {0}", probuto1.CalcularDesconto());

            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;//Aceder uma variavél estática

            Console.WriteLine("Preço com desconto: {0}", probuto1.CalcularDesconto());

            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
