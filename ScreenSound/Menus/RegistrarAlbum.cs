using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class RegistrarAlbum : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        Console.Clear();
        ExibirTituloDaOpcao("Registro de Albuns");
        if (bandasRegistradas.Count > 0)
        {
            ExibirTituloDaOpcao("Avaliar uma Banda!");
            Console.Write("Digite o nome da banda desejada: ");
            string nomebanda = Console.ReadLine()!;

            // ".ContainsKey" foi usado para verificar se existe uma chave no dicionario com o nome digitado
            if (bandasRegistradas.ContainsKey(nomebanda))
            {
                Banda banda = bandasRegistradas[nomebanda];
                Console.Write($"\nQual o nome do album: ");
                string album = Console.ReadLine()!;
                banda.AdicionarAlbum(new Album(banda.OrdemAlbuns, album));
                Console.WriteLine($"O {album} foi registrado na Banda {nomebanda} com sucesso!\n");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"Banda {nomebanda} não está registrada\n");
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
