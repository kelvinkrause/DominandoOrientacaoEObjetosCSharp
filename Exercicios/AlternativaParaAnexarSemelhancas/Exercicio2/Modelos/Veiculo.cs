namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio2.Modelos
{
    public class Veiculo : IPilotavel, IVoavel
    {
        public void Pilotar()
        {
            Console.WriteLine("Pilotando...");
        }


        public void Voar()
        {
            Console.WriteLine("Voando...");
        }

    }
}