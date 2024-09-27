namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Consulta
    {
        public Medico Medico { get; }
        public string Data { get; }
        public Pet Pet { get; }

        public Consulta(Medico medico, Pet pet, string data)
        {
            Medico = medico;
            Pet = pet;
            Data = data;
        }
    }
}