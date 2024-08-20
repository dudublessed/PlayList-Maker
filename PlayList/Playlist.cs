using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    class Playlist
    {
        List<Musica> musicas = new List<Musica>();

        public string nome;
        public string descricao;


        public Playlist(string name, string description)
        {
            nome = name;
            descricao = description;
        }

        public void Inserir()
        {
            Console.WriteLine("Digite o titulo da música: ");
            string musicTitle = Console.ReadLine();

            Console.WriteLine("Digite o nome do artista dessa música: ");
            string artistName = Console.ReadLine();

            Console.WriteLine("Digite o nome do album dessa música: ");
            string albumName = Console.ReadLine();

            Console.WriteLine("Digite a data dessa música: ");
            string inputDate = Console.ReadLine();

            DateTime musicDate;
            DateTime.TryParse(inputDate, out musicDate);

            Console.WriteLine("Digite o tempo de duração dessa música: ");
            string inputDuration = Console.ReadLine();

            TimeSpan musicDuration;
            TimeSpan.TryParse(inputDuration, out musicDuration);

            Musica music = new Musica(musicTitle, artistName, albumName, musicDate, musicDuration);
            musicas.Add(music);

            Console.WriteLine("Perfeito! Informações da música: ");
            music.ToString();
    
        }

        public void Listar()
        {
            int i = 0;

            foreach (Musica musica in musicas)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Título da " + (i + 1) + " música: " + musica.titulo);
                Console.WriteLine("Artista da " + (i + 1) + " música: " + musica.artista);
                Console.WriteLine("Album da " + (i + 1) + " música: " + musica.album);
                Console.WriteLine("Data da " + (i + 1) + " música: " + musica.dataInclusao.ToString());
                Console.WriteLine("Duração da " + (i + 1) + " música: " + musica.duracao.ToString());

                Console.WriteLine(" ");
                Console.WriteLine("_________________________________");
                Console.WriteLine(" ");
                i++;
            }
        }

        public void TempoTotal()
        {
            TimeSpan totalTime = TimeSpan.Zero;

            foreach (Musica musica in musicas)
            {
                totalTime += musica.duracao;
            }

            Console.WriteLine("Tempo total da playlist: " + totalTime.ToString());
        }

        public void ToString()
        {

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrição: " + descricao);

        }
    }

}

