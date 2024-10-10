using System.Reflection.Metadata.Ecma335;

namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Modelos
{
    public class Visitante : IResumoAcesso
    {
        public string Nome { get; }
        public string Documento { get; }
        public string Sala { get; }
        public string Resumo { get; }


        public Visitante(string nome, string documento, string sala, string resumo)
        {
            this.Nome = nome;
            this.Documento = documento;
            this.Sala = sala;
            this.Resumo = resumo;
        }
    }
}