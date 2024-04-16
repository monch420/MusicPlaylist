using System;
using BusinessLogic;
using System.Collections.Generic;
using Model;
using System.Net.Http.Headers;
using System.Transactions;

namespace UI
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            PlaylistBusinessLogic businessLogic = new PlaylistBusinessLogic();

            Console.WriteLine("\r\n  __  __ _   _ ___ ___ ___   ___ _      ___   ___    ___ ___ _____ \r\n |  \\/  | | | / __|_ _/ __| | _ \\ |    /_\\ \\ / / |  |_ _/ __|_   _|\r\n | |\\/| | |_| \\__ \\| | (__  |  _/ |__ / _ \\ V /| |__ | |\\__ \\ | |  \r\n |_|  |_|\\___/|___/___\\___| |_| |____/_/ \\_\\_| |____|___|___/ |_|  \r\n                                                                   \r\n\n------------------------------");

            foreach (Song song in businessLogic.DisplayPlaylistInfo())
            {
                Console.WriteLine($"{song.artist} - {song.title}\n------------------------------");
            }

            Console.WriteLine("\n[1] PLAY SONG \n[2] ADD SONG \n[3] REMOVE SONG \n[4] DISPLAY PLAYLIST INFORMATION \n[5] EXIT\n \nENTER: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\nENTER SONG TITLE: \n");
                string songTitle = Console.ReadLine();

                bool found = businessLogic.VerifySong(songTitle);

                if (found)
                {
                    Console.WriteLine("\n------------------------------\n♫ NOW PLAYING: " + songTitle +" \n------------------------------");
                }
                else
                {
                    Console.WriteLine("\nSONG NOT FOUND");
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("\nENTER TITLE: ");
                string userTitle = Console.ReadLine();
                Console.WriteLine("\nENTER ARTIST: ");
                string userArtist = Console.ReadLine();

                Console.WriteLine("\r\n  _   _ ___ ___   _ _____ ___ ___    __  __ _   _ ___ ___ ___   ___ _      ___   ___    ___ ___ _____ \r\n | | | | _ \\   \\ /_\\_   _| __|   \\  |  \\/  | | | / __|_ _/ __| | _ \\ |    /_\\ \\ / / |  |_ _/ __|_   _|\r\n | |_| |  _/ |) / _ \\| | | _|| |) | | |\\/| | |_| \\__ \\| | (__  |  _/ |__ / _ \\ V /| |__ | |\\__ \\ | |  \r\n  \\___/|_| |___/_/ \\_\\_| |___|___/  |_|  |_|\\___/|___/___\\___| |_| |____/_/ \\_\\_| |____|___|___/ |_|  \r\n                                                                                                      \r\n\n------------------------------");

                foreach (Song song in businessLogic.AddedSongInList(userTitle, userArtist))
                {
                    Console.WriteLine($"{song.artist} - {song.title}\n------------------------------");
                }
            }

            else if (choice == 3)
            {
                Console.Write("\nENTER TITLE: ");
                string songTitle = Console.ReadLine();

                bool found = businessLogic.VerifySong(songTitle);

                if (found)
                {
                    businessLogic.RemovedSongInList(songTitle);

                    Console.WriteLine("\r\n  _   _ ___ ___   _ _____ ___ ___    __  __ _   _ ___ ___ ___   ___ _      ___   ___    ___ ___ _____ \r\n | | | | _ \\   \\ /_\\_   _| __|   \\  |  \\/  | | | / __|_ _/ __| | _ \\ |    /_\\ \\ / / |  |_ _/ __|_   _|\r\n | |_| |  _/ |) / _ \\| | | _|| |) | | |\\/| | |_| \\__ \\| | (__  |  _/ |__ / _ \\ V /| |__ | |\\__ \\ | |  \r\n  \\___/|_| |___/_/ \\_\\_| |___|___/  |_|  |_|\\___/|___/___\\___| |_| |____/_/ \\_\\_| |____|___|___/ |_|  \r\n                                                                                                      \r\n\n------------------------------");

                    foreach (Song song in businessLogic.RemovedSongInList(songTitle))
                    {
                        Console.WriteLine($"{song.artist} - {song.title}\n------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("\nSONG NOT FOUND");
                }
            }

            else if (choice == 4)
            {
                Console.WriteLine("\r\n  ___ _      ___   ___    ___ ___ _____   ___ _  _ ___ ___  ___ __  __   _ _____ ___ ___  _  _ \r\n | _ \\ |    /_\\ \\ / / |  |_ _/ __|_   _| |_ _| \\| | __/ _ \\| _ \\  \\/  | /_\\_   _|_ _/ _ \\| \\| |\r\n |  _/ |__ / _ \\ V /| |__ | |\\__ \\ | |    | || .` | _| (_) |   / |\\/| |/ _ \\| |  | | (_) | .` |\r\n |_| |____/_/ \\_\\_| |____|___|___/ |_|   |___|_|\\_|_| \\___/|_|_\\_|  |_/_/ \\_\\_| |___\\___/|_|\\_|\r\n                                                                                               \r\n");

                foreach (Song song in businessLogic.DisplayPlaylistInfo())
                {
                    Console.WriteLine($"------------------------------\nTITLE: {song.title} \nARTIST: {song.artist} \nALBUM: {song.album} \nDURATION: {song.duration} \n------------------------------");
                }
            }

            else if (choice == 5)
            {
                return;
            }             
        }
    }
}
