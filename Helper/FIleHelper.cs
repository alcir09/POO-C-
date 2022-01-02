namespace Program.Helper
{
    public class FIleHelper
    {
        public void ListarDiretório( string caminho){

           var retornoCaminho = Directory.GetDirectories(caminho);

            foreach ( var retorno in retornoCaminho){

                System.Console.WriteLine(retorno);
            }

        }
    }
}