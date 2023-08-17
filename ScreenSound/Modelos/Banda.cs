namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    
    public void AdicionarAlbum (Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Dicografia do album da banda {Nome}.");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} - ({album.DuracaoTotal}s.)");
        }
    }
}