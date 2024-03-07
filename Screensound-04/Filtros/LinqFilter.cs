using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound_04.Modelos;

namespace Screensound_04.Filtros;

internal class LinqFilter
{
    // EXIBIR TODOS OS GÊNEROS MUSICAIS
    public static void FiltrarTodosOsGenerosMusicais(List<Musicas> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList(); ;
        // TODOS OS GÊNEROS UNICOS: DISTINCT
        // SER UMA LISTA: ToList
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musicas> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList(); ;
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musicas> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine($"Exibindo as musicas do artista >>> {nomeDoArtista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"{musica.Nome}");
        }
    }

  
    public static void FiltrarNumeros(List<int> numero)
    {
        var numerosUnicos = numero.Distinct();
        

        foreach(var number in numerosUnicos)
        {
            Console.WriteLine(number);
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musicas> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}\n");
        }

    }
}
