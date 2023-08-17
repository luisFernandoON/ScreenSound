namespace ScreenSound.Modelos;
internal class Album
{
    private List<Musica> Musicas = new List<Musica>();

    public Album(int ordem, string nome)
    {
        Ordem = ordem;
        Nome = nome;
    }
    public int Ordem { get; }
    public string Nome { get;}
   
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void MostrarAlbum()
    {
        Console.WriteLine($"Musicas do album {Nome}\n");

        Console.WriteLine($"A duração total do Album é {DuracaoTotal}s\n");

        foreach (var item in Musicas)
        {
            Console.WriteLine($"Musica: {item.Nome}");
        }
    }
}