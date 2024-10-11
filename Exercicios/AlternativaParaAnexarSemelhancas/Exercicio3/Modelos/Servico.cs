namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio3.Modelos
{
    public class Servico : IPagavel
    {
        public string Nome { get; set; }
        public double TaxaHoraria { get; set; }
        public int HorasTrabalhadas { get; set; }

        public double CalcularPagamento()
        {
            return TaxaHoraria * HorasTrabalhadas;
        }

    }
}