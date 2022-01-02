using System;
using Program.Models;

namespace Program{

    class Program {

        static void Main(string[] args) {

            Corrente c = new Corrente();

            c.Creditar(100);
            c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));

            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));

            // System.Console.WriteLine("Você é professor (P) ou aluno (A) ?");
            // string opcao = Console.ReadLine();

            // if(opcao.ToUpper() == "A"){


            // }

            // Aluno p1 = new Aluno();
            
            // Professor p2 = new Professor();

            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 7.5;

            // p1.Apresentar();

            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Salario = 5000.500;

            // p2.Apresentar();

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