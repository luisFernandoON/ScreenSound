namespace ScreenSound.Modelos;
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"O nome da música é \"{Nome}\", e seu artista é {Artista}.";

        //Primeiro método 
    /*
    { 
        get
        {
            return $"O nome da música é {Nome}, e seu artista é {Artista}";
        }  
    }
    */

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}s");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine(DescricaoResumida);

        if (Disponivel)
        {
            Console.WriteLine("Música disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus+.\n");
        }
    }

} 