namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio5.Modelos
{
    public class BancoDeDados : IArmazenavel
    {
        public string? NomeBancoDeDados { get; set; }

        public void Recuperar()
        {
            Console.WriteLine($"Recupera nome Banco de Dados {NomeBancoDeDados}");
        }

        public void Salvar()
        {
            Console.WriteLine($"Salva nome Banco de Dados {NomeBancoDeDados}");
        }

    }
}