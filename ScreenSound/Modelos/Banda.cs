namespace ScreenSound.Modelos;
internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(int ordem, string nome)
    {
        Ordem = ordem;
        Nome = nome;
    }

    public int Ordem { get; }
    public string Nome { get; }
    public double MediaBanda
    {
        get
        {
            if (notas.Count() == 0) return 0;
            else return notas.Average(e => e.Nota);
        }
    }
    public int OrdemAlbuns => (albuns.Count())+1;
    
    public void AdicionarAlbum (Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.Write($"Banda {Nome} - Nota: ");
        if (MediaBanda == 0)
        {
            Console.WriteLine("Não possui nota!");
        }
        else
        {
            Console.WriteLine(MediaBanda);
        }
        Console.WriteLine("===Albuns===");

        if (albuns.Count > 0) {
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (Album album in albuns.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"Album {album.Ordem}: {album.Nome} - ({album.DuracaoTotal}s)");
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }else
        {
            Console.WriteLine("Não existe album registrado!");
        }
        Console.WriteLine("===------===");

    }
}