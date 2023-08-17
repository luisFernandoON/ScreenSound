namespace ScreenSound.Menus;

internal class Menu
{
    // essa função tem por objetivo pegar um titulo que eu digitar, inseri-lo na variavel titulo e realizar uma analise para inplementar asteristicos nos titulos.
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeLetras = titulo.Length; // Faz a conta de cada caracter no titulo.
                                              // Cria uma "string" vazia que recebera por meio do "PadLeft" o caracter que desejo deacordo com a quantidade de letras no titulo.
        string asteristicos = string.Empty.PadLeft(quantidadeLetras, '*');
        // Impressão do titulo.
        Console.WriteLine(asteristicos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristicos + "\n");
    }
}
