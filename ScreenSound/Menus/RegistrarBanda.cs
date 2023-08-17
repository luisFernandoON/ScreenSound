using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class RegistrarBanda : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        // "Console.Clear();" usado para limpar o console.
        Console.Clear();
        ExibirTituloDaOpcao("Registro de Bandas");
        Console.WriteLine("Quantas bandas deseja registrar?");
        int quantidadeRegistro = int.Parse(Console.ReadLine()!);

        // "for" usado para realizar a quantidade de registros o usuário deseja.
        for (int i = 0; i < quantidadeRegistro; i++)
        {
            int OrdemBandas = bandasRegistradas.Keys.Count() + 1;
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = new Banda(OrdemBandas, nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);

            if (quantidadeRegistro == 1)
            {
                Console.WriteLine($"\nA Banda {nomeBanda} foi registrada com sucesso!\n");
            }
        }

        if (quantidadeRegistro > 1)
        {
            Console.WriteLine("\nAs bandas foram registrada com sucesso!\n");
        }

        // esse comando tem a função de espera por um determinado tempo para continuar a execução.
        Thread.Sleep(3000);
        Console.Clear();
    }
}
