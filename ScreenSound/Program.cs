// Screen Sound
using ScreenSound.Modelos;
using ScreenSound.Menus;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda Djavu = new(1, "Djavu");
        Djavu.AdicionarNota(new(10));
        Djavu.AdicionarNota(new(9));
        Djavu.AdicionarNota(new(8));
        Banda ForroBoys = new(2, "Forro Boys");
        ForroBoys.AdicionarNota(new(10));
        ForroBoys.AdicionarNota(new(10));
        ForroBoys.AdicionarNota(new(10));

        /*formato usado nos primordios:
        ---------------------------------------------------------------------------------------
        List<string> ListaDasBandas = new List<string>(); --> criar uma lista vazia.
        List<string> ListaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"}; 
        ---------------------------------------------------------------------------------------
        */

        // Um dicionario armazena uma "Chave" e um valor referente aquela chave.
        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(Ofendedoresv.Nome, Djavu);
        bandasRegistradas.Add(LenoBrega.Nome, ForroBoys);

        // "void" usado para criar funções que não retorna valores.
        void ExibirLogo()
        {
            string mensagemDeBoasVindas = " Boas vindas ao Screen Sound!";
            Console.WriteLine(@"
    
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine(mensagemDeBoasVindas);
        }

        void ExibirOpcoesMenu()
        {
            ExibirLogo();
            // Exibe as opções para o usuário.
            Console.WriteLine("\nDigite 1 para registar uma banda!");
            Console.WriteLine("Digite 2 para registar o album de uma banda!");
            Console.WriteLine("Digite 3 para visualizar todas as bandas!");
            Console.WriteLine("Digite 4 para registrar uma nota para uma banda!");
            Console.WriteLine("Digite 5 para exibir a discografia das Bandas!");
            Console.WriteLine("Digite -1 para fechar!");

            // Pergunta e captura o valor inserido pelo usuário.
            Console.Write("\nDigite a opção escolhida: ");
            int opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

            // forma rapida de verificar qual das opções o usuario deseja utilizar.
            switch (opcaoEscolhidaNumerica){
                case 1:
                    RegistrarBanda banda = new();
                    banda.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    break;
                case 2:
                    RegistrarAlbum album = new();
                    album.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    break;
                case 3:
                    ExibirBandas bandas = new();
                    bandas.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    break;
                case 4:
                    AvaliarUmaBanda avaliar = new();
                    avaliar.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    break;
                case 5:
                    MenuExibirDetalhes menu = new();
                    menu.Executar(bandasRegistradas);
                    ExibirOpcoesMenu();
                    break;
                case -1:
                    Console.WriteLine("Tchau Tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção não existe, tente novamente");
                    Console.Clear();
                    ExibirOpcoesMenu();
                    break;
            }
        }

        ExibirOpcoesMenu();
    }
}

