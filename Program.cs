using System;

      /*
      This program is a Mad Libs word game.
      Author: Anvarkhon Khamzaev
      */

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start the game");
            string title = "MAD LIBS";
            Console.WriteLine(title);

            Console.Write(" • Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}! Now wou will need to enter words one-by-one.");
            // 3 adjectives
            Console.Write(" • Enter the first adjective: ");
            string firstAdj = Console.ReadLine();

            Console.Write(" • Enter the second adjective: ");
            string secondAdj = Console.ReadLine();

            Console.Write(" • Enter the third adjective: ");
            string thirdAdj = Console.ReadLine();

            // 1 verb
            Console.Write(" • Enter a verb (word that describes action e.g. eat, run): ");
            string verb = Console.ReadLine();

            Console.WriteLine($"{name}, you are doing great, let's make your story really funny.");

            // 2 nouns
            Console.Write(" • Enter the first noun (A noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’)): ");
            string firstNoun = Console.ReadLine();

            Console.Write(" • Enter the second noun: ");
            string secondNoun = Console.ReadLine();

            // 7 words
            Console.Write(" • Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write(" • Enter a food: ");
            string food = Console.ReadLine();

            Console.Write(" • Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write(" • Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write(" • Enter a country: ");
            string country = Console.ReadLine();

            Console.Write(" • Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write(" • Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";

            // Print the story:
            Console.WriteLine("Here is your story");
            Console.WriteLine(story);
        }
    }
}
