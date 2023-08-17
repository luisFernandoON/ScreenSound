using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class ExibirBandas : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        if (bandasRegistradas.Count > 0)
        {
            ExibirTituloDaOpcao("Bandas Registradas");
            for (int i = 0; i < bandasRegistradas.Keys.Count; i++)
            {
                string Nomebanda = bandasRegistradas.Keys.ElementAt(i);
                Banda banda = bandasRegistradas[Nomebanda];
                Console.Write($"{banda.Ordem} - {banda.Nome} | Nota: ");

                if (banda.MediaBanda == 0)
                {
                    Console.WriteLine("Não possui nota!");
                }
                else
                {
                    Console.WriteLine(banda.MediaBanda);
                }
            }
        }
        else
        {
            Console.WriteLine("Não existe bandas registradas!");
        }
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
