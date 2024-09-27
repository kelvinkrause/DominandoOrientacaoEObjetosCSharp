namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Medico
    {
        public string Nome { get; }
        public string Crm { get; }

        public Medico(string nome, string crm)
        {
            Nome = nome;
            Crm = crm;
        }
    }
}