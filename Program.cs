using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collectins Practice");
            // ThreeBasics 

            int[] numbers = {0,1,2,3,4,5,6,7,8,9};

            string[] names = {"Mr. Nibbles","Benny Bob", "Walter Martin","Adrien"};

            bool[] bools = new bool[10];
            for(var i = 0; i < bools.Length; i++)
            {
                if( i % 2 == 0)
                {
                    bools[i] = true;
                }
                if( i % 2 == 1)
                {
                    bools[i] = false;
                }
            }

            // List Of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Cake Batter");
            flavors.Add("Chocalte Chip");
            flavors.Add("Peppermint");
            Console.WriteLine($"List if ice cream flavors is {flavors.Count}");
            Console.WriteLine($"Favorite flavor: {flavors[2]}");
            flavors.RemoveAt(2);
            Console.WriteLine($"List if ice cream flavors is {flavors.Count}");

            // User Info Dictionary

            Dictionary<string,string> favorites = new Dictionary<string, string>();

            foreach(string name in names)
            {
                Random rand = new Random();
                favorites.Add(name,flavors[rand.Next(flavors.Count)]);
            }

            foreach(KeyValuePair<string,string> entry in favorites)
            {
                Console.WriteLine($"{entry.Key} loves {entry.Value}");
            }
        }

        
    }
}
