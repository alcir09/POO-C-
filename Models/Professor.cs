namespace Program.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public override void Apresentar(){

            Console.WriteLine($"Olá, sou o professor {Nome} e tenho um salário de {Salario}");
        }
    }
}