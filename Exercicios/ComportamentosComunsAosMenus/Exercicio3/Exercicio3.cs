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


        void MenuOpcoes(ContaBancaria contaBancaria)
        {
            Console.WriteLine($"Bem vindo a sua conta corrente ");
            Console.WriteLine("Digite 1 para realizar um deposito");
            Console.WriteLine("Digite 2 para realizar um saque");
            Console.WriteLine("Digite 3 para ver seu saldo");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nEscolha uma opção");
            string opcaoEscolhida = Console.ReadLine()!;

        }

        void RetornaMenu()
        {
            Console.Write("Tecle enter para voltar ao menu. ");
            Console.ReadKey(true);
            Console.Clear();
        }

        void Sair()
        {
            Console.Clear();
            Console.WriteLine("Tchau Tchau");
            Thread.Sleep(400);
            Console.Clear();
        }

    }
}