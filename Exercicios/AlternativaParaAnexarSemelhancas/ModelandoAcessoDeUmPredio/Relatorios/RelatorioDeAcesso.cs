using ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Controlador;
using ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Modelos;

namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Relatorios
{
    public class RelatorioDeAcesso
    {
        private List<AcessoAoPredio> acessos = new List<AcessoAoPredio>();

        public void RegistrarEntrada(IResumoAcesso resumo)
        {
            acessos.Add(new AcessoAoPredio(DateTime.Now, ""));
        }

        public void ExibirRegistroDoMes()
        {
            Console.WriteLine($"Acessos registrador no mês:");
            foreach (var acesso in acessos)
            {
                Console.WriteLine($" - {acesso.Resumo} em {acesso.Entrada}");
            } 
        }
    }
}