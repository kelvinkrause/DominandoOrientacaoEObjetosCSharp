namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Controlador
{
    public class AcessoAoPredio
    {
        public DateTime Entrada { get; }
        public string Resumo { get; }

        public AcessoAoPredio(DateTime entrada, string resumo)
        {
            Entrada = entrada;
            Resumo = resumo;
        }
    }
}