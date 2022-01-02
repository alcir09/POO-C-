using System;
using Program.Models;

namespace Program{

    class Program {

        static void Main(string[] args) {

            // System.Console.WriteLine("Você é professor (P) ou aluno (A) ?");
            // string opcao = Console.ReadLine();

            // if(opcao.ToUpper() == "A"){


            // }

            Aluno p1 = new Aluno();

            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Nota = 7.5;

            p1.Apresentar();

            // //Valore validos
            // Retangulo r = new Retangulo();

            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valore inválidos
            // Retangulo r2 = new Retangulo();

            // r2.DefinirMedidas(0,0);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();

        }
    }
}