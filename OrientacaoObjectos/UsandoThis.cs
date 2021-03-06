﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro: ..: {nome} :.. incluido");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }

    class UsandoThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var boby = new Cachorro("Boby", 35.12);

            Console.WriteLine(spike);
            Console.WriteLine();
            Console.WriteLine(boby);
        }
    }
}
