namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio5.Modelos
{
    public class Arquivo : IArmazenavel
    {
        public string? NomeArquivo { get; set; }

        public void Recuperar()
        {
            Console.WriteLine($"Recuperando arquivo {NomeArquivo}");
        }

        public void Salvar()
        {
            Console.WriteLine($"Salvando arquivo {NomeArquivo}");;
        }

    }
}