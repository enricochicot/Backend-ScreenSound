namespace Backend_ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao (int nota)
    {
        nota = nota;
    }
    public int Nota { get; }

    public static Avaliacao Parse (string texto)
    {
        int nota = int.Parse (texto);
        return new Avaliacao (nota);
    }
}
