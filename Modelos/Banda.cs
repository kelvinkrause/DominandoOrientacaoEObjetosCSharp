﻿namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public List<Album> Albuns => albuns;

    public string Nome { get; }
    public double Media 
    {
        get 
        {
            if(notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($" - Álbum: {album.Nome}, Nota Média: {album.Media}, Duração: {album.DuracaoTotal}");
        }
    }
}