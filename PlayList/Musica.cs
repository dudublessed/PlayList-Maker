using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    class Musica
    {
        public string titulo;
        public string artista;
        public string album;
        public DateTime dataInclusao;
        public TimeSpan duracao;

        public Musica(string titleName, string artistName, string albumName, DateTime dataTime, TimeSpan duration)
        {
            titulo = titleName;
            artista = artistName;
            album = albumName;
            dataInclusao = dataTime;
            duracao = duration;
        }

        public void ToString()
        {
            Console.WriteLine("Título da música: " + titulo);
            Console.WriteLine("Artista: " + artista);
            Console.WriteLine("Album: " + album);
            Console.WriteLine("Data de Inclusão: " + dataInclusao.ToString());
            Console.WriteLine("Duração: " + duracao.ToString());
        }

    }
}
