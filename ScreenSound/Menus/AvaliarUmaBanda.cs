using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class AvaliarUmaBanda : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Digite qual banda quer avaliar
        //Se a banda existe no dicionario >> adiciona uma nota
        //volta para menu
        Console.Clear();
        bool continuar = true;
        while (continuar)
        {
            ExibirTituloDaOpcao("Avaliar uma Banda!");
            Console.Write("Digite o nome da banda desejada: ");
            string nomebanda = Console.ReadLine()!;

            // ".ContainsKey" foi usado para verificar se existe uma chave no dicionario com o nome digitado
            if (bandasRegistradas.ContainsKey(nomebanda))
            {
                Banda banda = bandasRegistradas[nomebanda];
                Console.Write($"\nQual nota a banda {nomebanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota.Nota} foi atribuida a Banda {nomebanda} com sucesso!\n");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"Banda {nomebanda} não está registrada\n");
            }

            Console.Write("\nDeseja continuar?(S/N): ");
            string maisAvaliacao = Console.ReadLine()!;

            if (maisAvaliacao == "S" || maisAvaliacao == "s")
            {
                continuar = true;
                Console.Clear();
            }
            else
            {
                continuar = false;
            }
        }
        Console.Clear();
    }
}
