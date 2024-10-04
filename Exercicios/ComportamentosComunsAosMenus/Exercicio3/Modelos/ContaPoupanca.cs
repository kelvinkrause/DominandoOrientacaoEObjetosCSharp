namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos
{
    public class ContaPoupanca : ContaBancaria
    {
        public string Titular { get; }
        public double TaxaRendimento { get; }

        public ContaPoupanca(string titular, double taxaManutencao)
        {
            Titular = titular;
            TaxaRendimento = taxaManutencao; 
        }

    }
}