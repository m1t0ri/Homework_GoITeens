using System;

using System.Collections.Generic;

namespace homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] singers =
            {
                "Eminem",
                "Sia",
                "Wham!",
                "Nirvana",
                "Blade and Bath"
            };
            int[] rating =
            {
                5,
                5,
                4,
                3,
                3
            };
            string[] songs =
            {
                "Rap God",
                "Snowman",
                "Last Christmas",
                "The Man who sold the world",
                "Jealous"
            };
            for (int s = 0; s < singers.Length; s++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Singers:{singers[s]} {rating[s]}; Their song:{songs[s]}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            
            int maxRating = rating[0];
            int maxIndex = 0;


            for (int i = 1; i < rating.Length; i++)
            {
                if (rating[i] > maxRating)
                {
                    maxRating = rating[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine("\nSong with the best rating:");
            Console.WriteLine($"Song: {songs[maxIndex]} - Rating: {maxRating}");

            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] == maxRating)
                {
                    Console.WriteLine(songs[i]);
                }
            }
            Console.ReadLine();
        }
    }
}