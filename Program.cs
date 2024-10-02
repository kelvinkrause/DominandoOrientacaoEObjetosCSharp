using System.Diagnostics.CodeAnalysis;
using ScreenSound.Exercicios;
using ScreenSound.Exercicios.NovaClasseAvaliacao;
using ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos;
using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        //new ExercicioExec();
        //new PetShop();
        //new Calculadora();
        //Console.ReadKey(true);


        Banda chaseAtlantic = new("Chase Atlantic");
        chaseAtlantic.AdicionarNota(new Avaliacao(10));
        chaseAtlantic.AdicionarNota(new Avaliacao(8));
        chaseAtlantic.AdicionarNota(new Avaliacao(6));
        Banda articMonkeys = new Banda("Arctic Monkeys");
        articMonkeys.AdicionarNota(new Avaliacao(10));
        articMonkeys.AdicionarNota(new Avaliacao(9));
        articMonkeys.AdicionarNota(new Avaliacao(8));

        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();

        bandasRegistradas.Add(chaseAtlantic.Nome, chaseAtlantic);
        bandasRegistradas.Add(articMonkeys.Nome, articMonkeys);

        Dictionary<int, Menu> opcoesMenu = new()
        {
            {0, new MenuSair()},
            {1, new MenuRegistrarBanda()},
            {2, new MenuRegistrarAlbum()},
            {3, new MenuMostrarBandasRegistradas()},
            {4, new MenuAvaliarBanda()},
            {5, new MenuExibirDetalhes()}
        };


        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            Menu menu = opcoesMenu[opcaoEscolhidaNumerica];


            if(opcoesMenu.ContainsKey(opcaoEscolhidaNumerica))
            {
                menu.Executar(bandasRegistradas);
                if(opcaoEscolhidaNumerica != 0) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

        }
    }
}