namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Modelos
{
    internal class Colaborador : IResumoAcesso
    {
        public int IdAcesso { get; }
        public string Resumo { get; }


        public Colaborador(int idAcesso, string resumo)
        {
            IdAcesso = idAcesso;
            Resumo = resumo;
        }
    }
}