using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Tiny Tina's Wonderlands");
            topGames.Add(2, "CS:GO");
            topGames.Add(3, "Halo 3");
            topGames.Add(4, "Elden Ring");
            topGames.Add(5, "Sonic Adventures 2");
            topGames.Add(6, "Kirby Airride");
            topGames.Add(7, "Donkey Kong 64");
            topGames.Add(8, "Runescape");
            topGames.Add(9, "GTA: San Andreas");
            topGames.Add(10, "Valorant");

            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }

            string result = "";

            topGames.TryGetValue(11, out result);

            if(result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Rocket League";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string favGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {favGame}");

            Hashtable capitals = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" }
            };

            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();

        }
    }
}
