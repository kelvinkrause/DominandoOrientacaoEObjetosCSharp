using ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos;

namespace ScreenSound.Exercicios.NovaClasseAvaliacao
{
    internal class PetShop
    {
        private List<Consulta> consultas = new List<Consulta>();
        private List<Pet> pets = new List<Pet>();
        private Dictionary<string, Dono> donos = new Dictionary<string, Dono>();

        public PetShop()
        {
            ExibirMenu();
        }

        void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para cadastrar um Pet");
            Console.WriteLine("Digite 2 para cadastrar o Dono");
            Console.WriteLine("Digite 3 para agendar uma Consulta");
            Console.WriteLine("Digite 4 exibir Cadastro do Dono");
            Console.WriteLine("Digite 0 para sair");
            Opcoes();
        }
        
        void Opcoes()
        {
            Console.Write("\nEscolha uma Opção: ");
            int opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 0: 
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                case 1: 
                    Console.Clear();
                    CadastrarPet();
                    break;
                case 2:
                    Console.Clear();
                    CadastrarDono();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Opção Agendar Consulta");
                    break;
                case 4:
                    Console.Clear();
                    ExibirCadastroDono();
                    break;
                default: 
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(400);
                    Console.Clear();
                    ExibirMenu();
                    break;
            }
        }

        void CadastrarPet()
        {
            Console.WriteLine("Cadastrar Pet\n");
            Console.Write("Infome seu nome: ");
            string nomeDono = Console.ReadLine()!;
            if(donos.ContainsKey(nomeDono)) //Dono existe
            {
                Console.Write("Informe a raça do animal: ");
                string racaAnimal = Console.ReadLine()!;
                Console.Write("Informe o nome do animal: ");
                string nomeAnimal = Console.ReadLine()!;
                Pet pet = new Pet(racaAnimal, nomeAnimal, donos[nomeDono]);
                pets.Add(pet);
                donos[nomeDono].AdicionarPet(pet);

                Console.WriteLine($"{nomeAnimal} cadastrado com sucesso ao Dono {nomeDono}.");
                RetornarMenu();
            }
            else //Dono não existe no cadastro
            {
                Console.WriteLine($"Nome {nomeDono} não encontrado no cadastro.");
                Console.Write("\nDigite 1 para realizar o cadastro ou 2 para retornar ao menu principal");
                int opcao = int.Parse(Console.ReadLine()!);
                switch(opcao)
                {
                    case 1:
                        Console.Clear();
                        CadastrarDono();
                        break;
                    case 2: 
                        ExibirMenu();
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        Thread.Sleep(400);
                        Console.Clear();
                        ExibirMenu();
                        break;
                }   
            }
        }

        void CadastrarDono()
        {
            Console.WriteLine("Cadastro do Dono");
            Console.Write("Informe o nome: ");
            string nomeDono = Console.ReadLine()!;
            if(!donos.ContainsKey(nomeDono))
            {
                donos.Add(nomeDono, new Dono(nomeDono, null));
                Console.WriteLine($"Dono {nomeDono} cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Nome {nomeDono} já existe no cadastro.");
            }
            RetornarMenu();
        }

        void RetornarMenu()
        {
            Console.Write("\nTecle alguma tecla para retornar ao menu: ");
            Console.ReadKey(true);
            ExibirMenu();
        }


        void ExibirCadastroDono()
        {
            Console.Write("Informe o nome: ");
            string dono = Console.ReadLine()!;
            if(dono.Contains(dono))
            {
                Console.WriteLine($"Pets do {dono}");
                donos[dono].Pets.
                    ForEach(animal => Console.WriteLine($"{animal.Nome}"));
            }
            RetornarMenu();
        }

    }
}