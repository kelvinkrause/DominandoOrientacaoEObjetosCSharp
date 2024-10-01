namespace ScreenSound.Exercicios.OrganizandoOProjeto.Modelos
{
    internal class Filme
    {
        public string Titulo { get; }
        public int Duracao { get; }
        public List<Artista> Elenco { get; set; }  

        public Filme(string titulo, int duracao, List<Artista> elenco)
        {
            Titulo = titulo;
            Duracao = duracao;

            if (elenco == null)
            {
                Elenco = new List<Artista>();
            }
            else 
            {
                Elenco = elenco;
                foreach(Artista artista in elenco)
                {
                    artista.AdicionarFilme(this);
                }
            }
        }


        public void AdicionarElenco(Artista artista)
        {
            Elenco.Add(artista);
            if(!artista.FilmesAtuados.Contains(this))
            {
                artista.FilmesAtuados.Add(this);
            }
            Console.WriteLine($"{artista.Nome} adicionado(a) ao Elenco!");
        }

        public void ListarElenco()
        {
            if(Elenco.Count == 0)
            {
                Console.WriteLine("Elenco Vazio");
            }
            else
            {
                Console.WriteLine($"Elenco do {Titulo}");
                Elenco.ForEach(elenco => Console.WriteLine($"Ator: {elenco.Nome}"));
            }
        }

    }
}