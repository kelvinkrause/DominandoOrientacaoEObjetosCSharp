using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Digite o album da banda {banda.Nome} que deseja avaliar: ");
            string nomeDoAlbum = Console.ReadLine()!;

            //Essa expressão, atavés da banda, verifica na lista de albuns dela, se tem algum "album" com o "Nome" igual ao digitado.
            if(banda.Albuns.Any(album => album.Nome.Equals(nomeDoAlbum)))
            {
                //Essa expressão, através da banda, verifica na lista de albuns dela, e pega a primeira ocorrência de "album" com o "Nome" igual ao digitado.
                Album album = banda.Albuns.First(album => album.Nome.Equals(nomeDoAlbum));

                Console.Write($"Qual a nota que album {album.Nome} merece: ");
                //int nota = int.Parse(Console.ReadLine()!);
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {album.Nome} da banda {banda.Nome}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO Album {nomeDoAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
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
