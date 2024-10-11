namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio3.Modelos
{
    public class Produto : IPagavel
    {
        public string Nome { get; }
        public int Quantidade { get; }
        public double PrecoUnitario { get; }

        public Produto(string nome, int quantidade, double precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public double CalcularPagamento()
        {
            return Quantidade * PrecoUnitario;
        }

    }
}