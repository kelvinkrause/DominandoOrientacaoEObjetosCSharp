namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos
{
    public class ContaBancaria
    {
        protected double Saldo;

        public virtual void Depositar(double valor)
        {
            Saldo = valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public virtual double CalcularSaldo()
        {
            return Saldo;
        }

    }
}