using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Menus
{
    internal class MenuPrincipal : Menu
    {

        public override void Executar(Dictionary<string, ContaBancaria> contas)
        {
            ExibirTituloDaOpcao(" Seja Bem-Vindo ao CashBank ");

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine()!;

            //if (contas.ContainsKey(titular).) //Parei aqui

            Console.WriteLine("Digite 1 para acessar a Conta Corrente");
            Console.WriteLine("Digite 2 para acessar a Conta Poupança");
            Console.WriteLine("Digite 0 para sair");
            Console.Write("Qual conta você deseja acessar: ");

            Console.Write("\nEscolha uma opção");
            string opcaoEscolhida = Console.ReadLine()!;

            Console.Clear();
            
            Console.WriteLine(opcaoEscolhida.Equals("1") ? "Conta Corrente" : "Conta Poupanca");
            

        }

    }
}