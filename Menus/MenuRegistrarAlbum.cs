using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public void RegistrarAlbum(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                bandasRegistradas[nomeDaBanda].AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}