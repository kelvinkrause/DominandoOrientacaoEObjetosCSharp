using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos;
using ScreenSound.Menus;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3
{
    public class Exercicio3
    {
        /*
        Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. 
        Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.
        */

        Dictionary<string, ContaCorrente> contasCorrentes = new Dictionary<string, ContaCorrente>();
        Dictionary<string, ContaBancaria> contasPoupancas = new Dictionary<string, ContaBancaria>();

        public Exercicio3()
        {
            ContaCorrente contaCorrenteKelvin = new ContaCorrente("Kelvin", 0.05);
            contasCorrentes.Add(contaCorrenteKelvin.Titular, contaCorrenteKelvin);
            ContaPoupanca contaPoupancaKelvin = new ContaPoupanca("Kelvin", 0.01);
            contasPoupancas.Add(contaPoupancaKelvin.Titular, contaPoupancaKelvin);


        }


    }
}