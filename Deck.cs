using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardApp
{
    class Deck
    { 
        public string DeckName { get; set; } = "Untitled"; 
        public List<Flashcard> FlashcardList = new List<Flashcard>();

        // Constructor
        public Deck(string name)
        {
            DeckName = name;
            Console.WriteLine("\"{0}\" deck has been created | Deck length: {1}\n", DeckName, FlashcardList.Count());
        }

        // For premade deck only
        public Deck(string name, IDictionary<string, string> termsDict)
        {
            DeckName = name;
            foreach (KeyValuePair<string, string> term in termsDict)
            {
                this.AddFlashcard(term.Key, term.Value);
            }
            Console.WriteLine("\"{0}\" deck has been created | Deck length: {1}\n", DeckName, FlashcardList.Count());
        }

        // Edit Deck Name
        public void EditDeckName(string newName)
        {
            DeckName = newName;
            Console.WriteLine("Deck has been renamed to \"{0}\"\n", DeckName);
        }

        // Show list of flashcards
        public void ShowFlashcards()
        {
            for (int i = 0; i < FlashcardList.Count(); i++)
            {
                Console.WriteLine($"{i}. FRONT: {FlashcardList[i].FrontCard}, BACK: {FlashcardList[i].BackCard}");
            }
        }

        // Show list of flashcards (Overload)
        public void ShowFlashcards(List<Flashcard> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine($"{i}. FRONT: {list[i].FrontCard}, BACK: {list[i].BackCard}");
            }
        }

        // Add flashcard
        public void AddFlashcard(string front, string back)
        {
            FlashcardList.Add(new Flashcard(front, back));
        }

        // Remove flashcard
        public void RemoveFlashcard(Flashcard flashcardObj)
        {
            Console.WriteLine("Flashcard with \"{0}\" in the front and \"{1}\" on the back has been removed\n", flashcardObj.FrontCard, flashcardObj.BackCard);
            FlashcardList.Remove(flashcardObj);
        }

        // Study in original order
        public void OriginalOrder()
        {
            // Copy original list
            List<Flashcard> tempStudyList = new List<Flashcard>(FlashcardList);
            Study(tempStudyList);
        }

        // Study in shuffled order
        public void Shuffle()
        {
            List<Flashcard> shuffledStudyList = new List<Flashcard>();

            // Copy original list
            List<Flashcard> copiedCardList = new List<Flashcard>(FlashcardList);

            // get # of flashcards
            int numOfCards;

            Random rnd = new Random();
            int rndIndex;

            while (true)
            {
                // Get number of flashcards in copied list
                numOfCards = copiedCardList.Count();

                // Pick a random number between 0 and number of cards left in list
                rndIndex = rnd.Next(0, numOfCards);

                // Add card to shuffled list
                shuffledStudyList.Add(copiedCardList[rndIndex]);

                // Remove card from copied list
                copiedCardList.RemoveAt(rndIndex);

                // If copied list is empty, then we have added all elements to our shuffled list
                // leave loop
                if (copiedCardList.Count() <= 0)
                {
                    break;
                }
            }

            Study(shuffledStudyList);
        }

        // Study
        void Study(List<Flashcard> studyList)
        {
            int correct = 0;
            string userGuess = "";

            // Test user for each card
            foreach (Flashcard card in studyList)
            {
                Console.WriteLine("\n");
                // Show front card
                card.ShowFront();

                // Get user input
                Console.Write("Guess: ");
                userGuess = Console.ReadLine();

                // Check if user input matches back card
                // if match, tell user is correct & increment correct
                // else, show back & increment wrong
                if (userGuess.ToLower() == card.BackCard.ToLower())
                {
                    Console.WriteLine("Correct!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Wrong! The answer was \"{0}\"", card.BackCard);
                }
            }

            // Summarize result
            Console.WriteLine("==============");
            Console.WriteLine("    Results   ");
            Console.WriteLine("==============");
            Console.WriteLine();
            Console.WriteLine("You got {0}/{1} cards correct", correct, studyList.Count());
        }
    }
}
