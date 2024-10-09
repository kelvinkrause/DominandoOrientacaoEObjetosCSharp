namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Dono
    {
        public string Nome { get; }
        public List<Pet> Pets {get;}

        public Dono(string nome, Pet? animal)
        {
            this.Nome = nome;
            if(animal != null)
            {
                Pets = new List<Pet>{animal};
            }
            else
            {
                Pets = new List<Pet>();
            }
            
        }

        public void AdicionarPet(Pet pet)
        {
            Pets.Add(pet);
        }
    }
}