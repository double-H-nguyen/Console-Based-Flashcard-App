using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardApp
{
    static class DeckCollection
    {
        public static List<Deck> DeckList = new List<Deck>();

        // Initialize pre-made decks
        public static void PreMadeDeck()
        {
            IDictionary<string, string> StateCapitalsDict = new Dictionary<string, string>()
            {
                {"Texas", "Austin"},
                {"New York", "Albany"},
                {"Alabama", "Montgomery"},
                {"Alaska", "Juneau"},
                {"Arizona", "Phoenix"},
                {"California", "Sacramento"},
                {"Colorado", "Denver"},
                {"Connecticut", "Hartford"},
                {"Delaware", "Dover"},
                {"Topeka", "Kansas"}
            };
            DeckList.Add(new Deck("States & Capitals", StateCapitalsDict));
            DeckList.Add(new Deck("TestDeck2"));
            DeckList.Add(new Deck("TestDeck3"));
        }

        // Show list of decks
        public static void ShowDecks()
        {
            for (int i = 0; i < DeckList.Count(); i++)
            {
                Console.WriteLine($"{i}. {DeckList[i].DeckName}");
            }
            Console.WriteLine();
        }

        // Add deck
        public static void AddDeck(string name)
        {
            DeckList.Add(new Deck(name));
        }

        // Remove deck
        public static void RemoveDeck(Deck deckObj)
        {
            Console.WriteLine("\"{0}\" deck has been removed", deckObj.DeckName); 
            DeckList.Remove(deckObj);
        }

    }
}
