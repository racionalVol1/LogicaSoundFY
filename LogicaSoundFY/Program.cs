using LogicaSoundFY.Modelos;

namespace LogicaSoundFY
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvinte ouvinte = new Ouvinte("João");
            Playlist playlist = new Playlist("Minha Playlist");
            Album album = new Album("Album 1", "Artista 1");

            Musica musica1 = new Musica("Musica 1", "Artista 1", "Album 1", "Pop");
            Musica musica2 = new Musica("Musica 2", "Artista 2", "Album 2", "Rock");

            album.AdicionarMusica(musica1);
            album.AdicionarMusica(musica2);

            playlist.AdicionarMusica(musica1);
            playlist.AdicionarMusica(musica2);

            ouvinte.AdicionarPlaylist(playlist);

            ouvinte.ListarPlaylists();
            
        }        
    }  
}