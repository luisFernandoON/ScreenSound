namespace ScreenSound.Modelos;

internal class Avaliacao
{

    public Avaliacao(int nota){

        if (nota < 0) Nota = 0;
        else if (nota > 10) Nota = 10;
        else Nota = nota;
    }

    public int Nota { get;}

    // na função abaixo criamos o nosso proprio tipo Parse(exemplo comum: int.Parse(...))
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

}
