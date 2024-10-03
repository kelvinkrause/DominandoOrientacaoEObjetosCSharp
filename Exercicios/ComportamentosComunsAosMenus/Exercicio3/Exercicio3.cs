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

        Dictionary<string, ContaCorrente> contasCorrentes;
        Dictionary<string, ContaPoupanca> contasPoupancas;

        public Exercicio3()
        {


        }


        void MenuOpcoes()
        {
            Console.WriteLine($"Bem vindo a sua conta corrente ");
            Console.WriteLine("Digite 1 para realizar um deposito");
            Console.WriteLine("Digite 2 para realizar um saque");
            Console.WriteLine("Digite 3 para ver seu saldo");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nEscolha uma opção");
            string opcaoEscolhida = Console.ReadLine()!;

            switch (opcaoEscolhida)
            {
                case "0":
                    Sair();
                    break;
                case "1":
                    //Depositar(conta);
                    break;
                case "2":
                    //Sacar(conta);
                    break;
                case "3":
                    //ExibirSaldo(conta);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }

        void RetornaMenu(ContaBancaria conta)
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