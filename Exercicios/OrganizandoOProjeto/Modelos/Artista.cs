namespace ScreenSound.Exercicios.OrganizandoOProjeto.Modelos
{
    internal class Artista
    {
        public string Nome { get; }
        public int Idade { get; }
        public int QuantidadeFilmes => FilmesAtuados.Count;
        public List<Filme> FilmesAtuados { get; set; }

        public Artista(string nome, int idade, List<Filme> filmes)
        {
            this.Nome = nome;
            this.Idade = idade;
            if (filmes != null)
            {
                this.FilmesAtuados = filmes;
            }
            else
            {
                this.FilmesAtuados = new List<Filme>();
            }
        }

        public void AdicionarFilme(Filme filme)
        {
            FilmesAtuados.Add(filme);
        }

        public void MostrarFilmesAtuados()
        {
            if(FilmesAtuados.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado para o artista {Nome}");
                return;
            }
            Console.WriteLine($"Filmes de {Nome}");
            FilmesAtuados.ForEach(filme => Console.WriteLine(filme.Titulo));
        }

    }
}