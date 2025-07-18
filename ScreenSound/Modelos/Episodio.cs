﻿namespace ScreenSound.Modelos;
internal class Episodio
{
    private List<string> Convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get;}
    public string Titulo { get;}
    public int Duracao { get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }
}