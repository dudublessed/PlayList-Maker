using System;


namespace PlayList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao PlayList em C#!");

            Console.WriteLine("Antes de tudo, vamos criar a sua Playlist!");

            Console.WriteLine("Qual o nome da sua Playlist?");
            string playlistName = Console.ReadLine();

            Console.WriteLine("Perfeito! Agora dê uma descrição a essa Playlist: ");
            string playlistDesc = Console.ReadLine();   


            Playlist playlist = new Playlist(playlistName, playlistDesc);

            Console.WriteLine("Playlist criada! Informações: ");
            playlist.ToString();

            Console.WriteLine("Agora vamos adicionar músicas para a sua Playlist!");

            playlist.Inserir();

            while (true)
            {
                Console.WriteLine("Muito bem! Você gostaria de colocar outra música (Inserir), ver as músicas que possui (Listar) ou ver o tempo total de sua Playlist(TempoTotal)?");
                Console.WriteLine("Caso não queira fazer nenhuma dessas funções, digite qualquer outra coisa.");
                string decision = Console.ReadLine();

                switch (decision.ToLower())
                {
                    case "inserir":
                        playlist.Inserir();
                        break;
                    case "listar":
                        playlist.Listar();
                        break;
                    case "tempototal":
                        playlist.TempoTotal();
                        break;
                    default:
                        Console.WriteLine("Muito obrigado por utilizar o programa! Até a próxima!");
                        return;
                }
            }


        }
    }

}