using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound_04.Modelos;

namespace Screensound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musicas> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach(var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        
    }

    

}
