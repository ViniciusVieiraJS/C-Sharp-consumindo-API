using Screensound_04.Modelos;
using System.Text.Json;
using Screensound_04.Filtros;


using (HttpClient client = new HttpClient()) // não colocar ; significa que vamos usar
                                             // o módulo apenas dentro do using
{
    try // ele vai TENTAR rodar isso
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>>(resposta)!; // pega esse Json e converte em um objeto manipulável no C#
        /* LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
         LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
         LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
         LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Red Hot Chili Peppers");*/
        /*musicas[1].ExibirDetalhesDaMusica();*/

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        /*var musicasPreferidasDoVini = new MusicasPreferidas("Vinicius");
        musicasPreferidasDoVini.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoVini.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasDoVini.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidasDoVini.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoVini.AdicionarMusicasFavoritas(musicas[5]);*/

      /*  var musicasPreferidasDoJean = new MusicasPreferidas("Jean");
        musicasPreferidasDoJean.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoJean.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasDoJean.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidasDoJean.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoJean.AdicionarMusicasFavoritas(musicas[5]);*/

       /* musicasPreferidasDoVini.ExibirMusicasFavoritas();
        musicasPreferidasDoVini.GerarArquivoJson();*/
    }
    catch (Exception ex) // EXCEÇÃO - SE VOCÊ NÃO CONSEGUIR O TRY, VC VAI PRA CÁ
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }

 
}