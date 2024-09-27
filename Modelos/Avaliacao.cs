namespace ScreenSound.Modelos;

internal class Avaliacao
{   
    public int Nota { get; }
    public Avaliacao(int nota)
    {
        if(nota <= 0) this.Nota = 0;
        if(nota >= 0) this.Nota = 10;
        this.Nota = nota;
    }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

}   
    