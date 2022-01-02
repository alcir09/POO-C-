namespace Program.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

         public override void Apresentar(){

            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno de {Nota}");
        }

        // public int Nota2 { get; set; }

        // public string CalcularMedia(int nota1, int nota2){

        //     if(nota1 < 0){

        //         return $"Notas {nota1} e {nota2} tem que ser maior ou igual a 0";

        //     }
        //     else{

        //         this.Nota1 = nota1;
        //         this.Nota2 = nota2;

        //         return 
        //     }
            

        // }


    }
}