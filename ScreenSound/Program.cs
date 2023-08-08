// Screen Sound

using ScreenSound.Modelos;

Banda Ofendedoresv = new("Ofendedoresv");
Banda LenoBrega = new("leno Brega");

/*formato usado nos primordios:
---------------------------------------------------------------------------------------
List<string> ListaDasBandas = new List<string>(); --> criar uma lista vazia.
List<string> ListaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"}; 
---------------------------------------------------------------------------------------
*/

// Um dicionario armazena uma "Chave" e um valor referente aquela chave.
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8, 7 });
bandasRegistradas.Add("The Beatles", new List<int>());


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
    // criei uma variavel Boleana para fazer com que o "While" rode ate ser parado pelo usuario.
    bool menu = true;
    while (menu)
    {
        ExibirLogo();
        // Exibe as opções para o usuário.
        Console.WriteLine("\nDigite 1 para registar uma banda!");
        Console.WriteLine("Digite 2 mostrar todas as bandas!");
        Console.WriteLine("Digite 3 para avaliar uma banda!");
        Console.WriteLine("Digite 4 para exibir a média de uma banda!");
        Console.WriteLine("Digite -1 para fechar!");

        // Pergunta e captura o valor inserido pelo usuário.
        Console.Write("\nDigite a opção escolhida: ");
        int opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);


        // forma rapida de verificar qual das opções o usuario deseja utilizar.
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                RegistroDeBandas();
                break;
            case 3:
                AvaliarUmaBanda();
                break;
            case 4:
                ExibirMediaDasBandas();
                break;
            case -1:
                Console.WriteLine("Tchau Tchau :)");
                menu = false;
                break;
            default:
                Console.WriteLine("Opção não existe, tente novamente");
                break;
        }
    }

}


void RegistrarBanda()
{
    // "Console.Clear();" usado para limpar o console.
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.WriteLine("Quantas bandas deseja registrar?");
    int quantidadeRegistro = int.Parse(Console.ReadLine()!);

    // "for" usado para realizar a quantidade de registros o usuário deseja.
    for (int i = 0; i < quantidadeRegistro; i++)
    {
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeBanda, new List<int>());
        // Console.WriteLine($"\nA Banda {nomeBanda} foi registrada com sucesso!\n"); --> outra forma de imprimir o conteudo dentro da mensagem.

        if (quantidadeRegistro == 1)
        {
            Console.WriteLine("\nA Banda {0} foi registrada com sucesso!\n", nomeBanda);
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


void RegistroDeBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("lista de Bandas");

    if (bandasRegistradas.Count > 0)
    {
        for (int i = 0; i < bandasRegistradas.Keys.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {bandasRegistradas.Keys.ElementAt(i)}");
        }
        /* Outro "for" que poderia se usado apra impremir seria o "foreach", veja abaixo como seria:

        foreach (string banda in bandasRegistradas.keys)
        {
            Console.WriteLine($"Banda: {Bandas}");
        } 
        */
    }
    else
    {
        Console.WriteLine("Não existe bandas registradas!");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu!");
    Console.ReadKey();
    Console.Clear();

}

// essa função tem por objetivo pegar um titulo que eu digitar, inseri-lo na variavel titulo e realizar uma analise para inplementar asteristicos nos titulos.
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length; // Faz a conta de cada caracter no titulo.
    // Cria uma "string" vazia que recebera por meio do "PadLeft" o caracter que desejo deacordo com a quantidade de letras no titulo.
    string asteristicos = string.Empty.PadLeft(quantidadeLetras, '*');
    // Impressão do titulo.
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarUmaBanda()
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
            Console.Write($"\nQual nota a banda {nomebanda} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            // Abaixo selecionamos a chave com o nome da variavel digitada e adicionamos a nota na chave.
            bandasRegistradas[nomebanda].Add(nota);
            Console.WriteLine($"A nota {nota} foi atribuida a Banda {nomebanda} com sucesso!\n");
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


void ExibirMediaDasBandas()
{
    Console.Clear();
    bool continuar = true;
    while (continuar)
    {
        ExibirTituloDaOpcao("Media das Bandas!");
        Console.Write("Digite o nome da banda desejada: ");
        string nomebanda = Console.ReadLine()!;

        // ".ContainsKey" foi usado para verificar se existe uma chave no dicionario com o nome digitado
        if (bandasRegistradas.ContainsKey(nomebanda))
        {
            // Abaixo selecionamos a chave com o nome da variavel digitada e fazemos sua media.
            double mediabanda = bandasRegistradas[nomebanda].Average();
            Console.WriteLine($"A Média da banda {nomebanda} é {mediabanda}\n");
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

ExibirOpcoesMenu();









// Exibição exemplo para usar masi tarde.
//---------------------------------------------------------------------------------
Episodio ep1 = new(2, "Mini-debate, cartucho de carabina ou GOZAR?", 124);
ep1.AdicionarConvidados("Bolsonaro");
ep1.AdicionarConvidados("Lula");

Episodio ep2 = new(1, "Quem Brinca muito um dia vira brinquedo", 42);
ep2.AdicionarConvidados("Arthor5games");
ep2.AdicionarConvidados("ParanoidEscape");


Podcast podcast = new("PodPinga", "Lois");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();
//---------------------------------------------------------------------------------
