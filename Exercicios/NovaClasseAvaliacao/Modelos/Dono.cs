namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Dono
    {
        public string Nome { get; }
        private List<Pet> pets = new List<Pet>();

        public Dono(string nome, Pet animal)
        {
            this.Nome = nome;
            if(animal != null)
            {
                pets.Add(animal);
            }
            else
            {
                pets = new List<Pet>();
            }
            
        }

        public void AdicionarPet(Pet pet)
        {
            pets.Add(pet);
        }
    }
}