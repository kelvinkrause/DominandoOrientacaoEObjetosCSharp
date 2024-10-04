namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Pet
    {
        public string Animal { get; }
        public string Nome { get; }
        public Dono Dono { get; }
        public List<Dono> DonosSecundarios { get; }
        public Pet(string animal, string nome, Dono donoDoAnimal)
        {
            Animal = animal;
            Nome = nome;
            Dono = donoDoAnimal;
            DonosSecundarios = new List<Dono>();
        }
        
    }
}