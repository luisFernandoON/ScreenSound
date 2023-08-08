namespace ScreenSound.Modelos;
class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} - Eps.total ({TotalEpisodios}) \nApresentado por {Host}\n");
        foreach(var episode in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episode.Resumo);
        }
        Console.WriteLine("");
    }


}