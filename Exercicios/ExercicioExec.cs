using ScreenSound.Exercicios.OrganizandoOProjeto.Modelos;

namespace ScreenSound.Exercicios
{

    public class ExercicioExec
    {

        private List<Filme> filmes = new List<Filme>();

        public ExercicioExec()
        {
            OrganizandoOProjeto();

        }

        void OrganizandoOProjeto()
        {

            filmes.Add(new Filme("Avatar", 180, new List<Artista>
            {
                new Artista("Matthew McConaughey", 54, new List<Filme>()),
                new Artista("Anne Hathaway", 41, new List<Filme>())
            }));

            filmes.Add(new Filme("Interestelar", 180, new List<Artista>
            {
                new Artista("Sam Worthington", 48, new List<Filme>()),
                new Artista("Zoë Saldaña", 46, new List<Filme>())
            }));

            Filme avatar = new Filme("Avatar", 180, new List<Artista>());
            Filme interestelar = new Filme("Interestelar", 180, new List<Artista>());


            foreach(Filme filme in filmes)
            {
                Console.WriteLine($"Filme: {filme.Titulo}");
                filme.ListarElenco();
                filme.Elenco.ForEach(elenco => elenco.MostrarFilmesAtuados());
            }


        }

    }
}