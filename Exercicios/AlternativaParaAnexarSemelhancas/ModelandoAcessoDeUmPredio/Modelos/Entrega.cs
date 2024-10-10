namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Modelos
{
    internal class Entrega : IResumoAcesso
    {
        public string Representante { get; }
        public string Resumo { get; }

        public Entrega(string representante, string resumo)
        {
            this.Representante = representante;
            this.Resumo = resumo;
        }
    }
}