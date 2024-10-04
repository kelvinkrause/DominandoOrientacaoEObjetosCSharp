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
        Dictionary<string, ContaPoupanca> contasPoupancas = new Dictionary<string, ContaPoupanca>();

        public Exercicio3()
        {
            ContaCorrente contaCorrenteKelvin = new ContaCorrente("Kelvin", 0.05);
            contasCorrentes.Add(contaCorrenteKelvin.Titular, contaCorrenteKelvin);
            ContaPoupanca contaPoupancaKelvin = new ContaPoupanca("Kelvin", 0.01);
            contasPoupancas.Add(contaPoupancaKelvin.Titular, contaPoupancaKelvin);

            MenuPrincipal();

        }


        void MenuPrincipal()
        {
            Console.WriteLine("Seja Bem Vindo ao CashBank");
            Console.WriteLine("Digite 1 para acessar a Conta Corrente");
            Console.WriteLine("Digite 2 para acessar a Conta Poupança");
            Console.WriteLine("Digite 0 para sair");
            Console.Write("Qual conta você deseja acessar: ");

            Console.Write("\nEscolha uma opção");
            string opcaoEscolhida = Console.ReadLine()!;

            switch (opcaoEscolhida)
            {
                case "0":
                    Sair();
                    break;
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            
        }

        void MenuOpcoes()
        {
            Console.WriteLine($"Bem vindo a sua conta corrente {}");
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
                    //Depositar();
                    break;
                case "2":
                    //Sacar();
                    break;
                case "3":
                    //ExibirSaldo();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

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