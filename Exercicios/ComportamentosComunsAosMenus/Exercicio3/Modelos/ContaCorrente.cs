namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos
{
    public class ContaCorrente : ContaBancaria
    {
        public string Titular { get; set; }

        protected double TaxaManutencao { get; set; }

        public ContaCorrente(string titular, double taxaManutencao)
        {
            Titular = titular;
            TaxaManutencao = taxaManutencao;
        }

        public override void Depositar(double valor)
        {
            base.Depositar(valor);
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor + this.TaxaManutencao);
        }

        public override double CalcularSaldo()
        {
            return base.CalcularSaldo();
        }

    }
}