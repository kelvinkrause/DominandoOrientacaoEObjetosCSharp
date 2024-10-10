using ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Modelos;
using ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio.Relatorios;

namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.ModelandoAcessoDeUmPredio
{
    public class Principal
    {
        public Principal()
        {
           
            Entrega entregaDePizza = new Entrega(representante: "Marcela", "Entregando pizza");
            Colaborador joseDaAlura = new Colaborador(idAcesso: 25, resumo: "Zullu WorkSpace");
            Colaborador mariaDaAcme = new Colaborador(idAcesso: 14, resumo: "Zullu WorkSpace");
            Visitante filhoDeMaria = new Visitante(nome: "Pedro", documento: "12938732", sala: "1002", "Entrevista na Zullu WorkSpace");

            RelatorioDeAcesso acessoMensal = new RelatorioDeAcesso();
            acessoMensal.RegistrarEntrada(entregaDePizza);
            acessoMensal.RegistrarEntrada(joseDaAlura);
            acessoMensal.RegistrarEntrada(mariaDaAcme);
            acessoMensal.RegistrarEntrada(filhoDeMaria);

            // ao final do mês...
            acessoMensal.ExibirRegistroDoMes();
        }
    }
}