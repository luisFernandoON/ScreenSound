using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        if (bandasRegistradas.Count > 0)
        {
            bool continuar = true;
            while (continuar)
            {
                ExibirTituloDaOpcao("Discografia da Banda");
                Console.Write("Digite o nome da banda desejada: ");
                string nomebanda = Console.ReadLine()!;

                // ".ContainsKey" foi usado para verificar se existe uma chave no dicionario com o nome digitado
                if (bandasRegistradas.ContainsKey(nomebanda))
                {
                    Banda banda = bandasRegistradas[nomebanda];
                    banda.ExibirDiscografia();
                    Console.WriteLine();
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
