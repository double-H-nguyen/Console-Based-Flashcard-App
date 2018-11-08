using System;
using System.Linq;

namespace FlashCardApp
{
    class Menu
    {
        public static int CollectionMenu()
        {
            bool validInput = false;

            while (true)
            {
                // Print options
                // Print title
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("==========================");
                Console.WriteLine("      Flash Card App      ");
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine("Type the option you want to select.");
                Console.WriteLine("1. Select Deck");
                Console.WriteLine("2. Add Deck");
                Console.WriteLine("3. Exit Program");

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Check if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);

                // Return user input if valid, else ask user to try again
                if (validInput)
                {
                    return parsedUserInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please type in a valid numerical choice.");
                }
            }
        }

        public static Deck SelectDeckMenu()
        {
            bool validInput = false;
            bool validDeck = false;

            while (true)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("===================");
                Console.WriteLine("    Select Deck    ");
                Console.WriteLine("===================");
                Console.WriteLine();
                Console.WriteLine("Type the appropriate number to select a deck.");

                // Show list of decks
                DeckCollection.ShowDecks();

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Checks if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);
                // Checks if user chose an existing deck
                if (parsedUserInput >= 0 && parsedUserInput < DeckCollection.DeckList.Count()) { validDeck = true; }

                // Return deck if valid, else ask user to try again
                if (validInput && validDeck)
                {
                    // return the appropriate deck object from DeckList
                    Console.WriteLine("You selected \"{0}\" deck.", DeckCollection.DeckList[parsedUserInput].DeckName);
                    return DeckCollection.DeckList[parsedUserInput];
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please try again.");
                }
            }
        }

        public static int SelectDeckActionMenu(Deck deckObj)
        {
            bool validInput = false;

            while (true)
            {
                // Print options
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("===================");
                Console.WriteLine("    Deck Options   ");
                Console.WriteLine("===================");
                Console.WriteLine();
                Console.WriteLine("Type the option you want for \"{0}\" deck.", deckObj.DeckName);
                Console.WriteLine("1. Study deck");
                Console.WriteLine("2. Edit deck");
                Console.WriteLine("3. Remove deck");

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Check if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);

                // Return user input if valid, else ask user to try again
                if (validInput)
                {
                    return parsedUserInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please type in a valid numerical choice.");
                }
            }
        }

        public static int StudyDeckMenu(Deck deckObj)
        {
            bool validInput = false;

            while (true)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("====================");
                Console.WriteLine("    Study Options   ");
                Console.WriteLine("====================");
                Console.WriteLine();

                // Print options
                Console.WriteLine("Type the study option you want for \"{0}\" deck.", deckObj.DeckName);
                Console.WriteLine("1. Original Order");
                Console.WriteLine("2. Shuffle");

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Check if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);

                // Return user input if valid, else ask user to try again
                if (validInput)
                {
                    return parsedUserInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please type in a valid numerical choice.");
                }
            }
        }

        public static int EditDeckMenu(Deck deckObj)
        {
            bool validInput = false;

            while (true)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("========================");
                Console.WriteLine("    Edit Deck Options   ");
                Console.WriteLine("========================");
                Console.WriteLine();

                // Print options
                Console.WriteLine("Type the option you want to edit \"{0}\" deck.", deckObj.DeckName);
                Console.WriteLine("1. Edit deck name");
                Console.WriteLine("2. Edit flashcard");
                Console.WriteLine("3. Add flashcard");

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Check if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);

                // Return user input if valid, else ask user to try again
                if (validInput)
                {
                    return parsedUserInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please type in a valid numerical choice.");
                }
            }
        }

        public static Flashcard SelectFlashcardMenu(Deck deckObj)
        {
            bool validInput = false;
            bool validFlashcard = false;

            while (true)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("===========================");
                Console.WriteLine("      Select Flashcard     ");
                Console.WriteLine("===========================");
                Console.WriteLine();
                Console.WriteLine("Type the appropriate number to select a flashcard.");

                // Show list of flashcards
                deckObj.ShowFlashcards();

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Checks if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);
                // Checks if user chose an existing deck
                if (parsedUserInput >= 0 && parsedUserInput < deckObj.FlashcardList.Count()) { validFlashcard = true; }

                // Return deck if valid, else ask user to try again
                if (validInput && validFlashcard)
                {
                    // return the appropriate deck object from DeckList
                    Console.WriteLine("You selected flashcard that contains: \"{0}\" in the front and \"{1}\" in the back.", 
                        deckObj.FlashcardList[parsedUserInput].FrontCard, deckObj.FlashcardList[parsedUserInput].BackCard);
                    return deckObj.FlashcardList[parsedUserInput];
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please try again.");
                }
            }
        }

        public static int SelectFlashcardActionMenu(Flashcard flashcardObj)
        {
            bool validInput = false;

            while (true)
            {
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("========================");
                Console.WriteLine("    Flashcard Options   ");
                Console.WriteLine("========================");
                Console.WriteLine();

                // Print options
                Console.WriteLine("Type the option you want for this flashcard.");
                Console.WriteLine("1. Edit front card");
                Console.WriteLine("2. Edit back card");
                Console.WriteLine("3. Remove card");

                // Record user input
                Console.Write("Enter input here: ");
                string userInput = Console.ReadLine();

                // Check if user input is a whole number
                validInput = Int32.TryParse(userInput, out int parsedUserInput);

                // Return user input if valid, else ask user to try again
                if (validInput)
                {
                    return parsedUserInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please type in a valid numerical choice.");
                }
            }
        }

        public static string[] AddFlashcardMenu()
        {
            string[] userInputArray = new string[2];

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("====================");
            Console.WriteLine("    Add Flashcard   ");
            Console.WriteLine("====================");
            Console.WriteLine();

            // Record user input for front card
            Console.WriteLine("Type in the term you want to be on the front");
            Console.Write("Front: ");
            userInputArray[0] = Console.ReadLine();

            // Record user input for back card
            Console.WriteLine("Type in the term you want to be on the back");
            Console.Write("Back: ");
            userInputArray[1] = Console.ReadLine();

            return userInputArray;
        }

        public static string EditDeckNameMenu()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("    Editing Deck Name   ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("Enter a new name");

            // Record user input
            Console.Write("Deck Name: ");
            return Console.ReadLine();
        }

        public static string EditFrontCardMenu()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("   Editing Front card   ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("Type in what you want to replace the front with:");

            // Record user input
            Console.Write("Front: ");
            return Console.ReadLine();
        }

        public static string EditBackCardMenu()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("    Editing Back card   ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("Type in what you want to replace the back with:");

            // Record user input
            Console.Write("Back: ");
            return Console.ReadLine();
        }

        public static string AddDeckMenu()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("===================");
            Console.WriteLine("      Add Deck     ");
            Console.WriteLine("===================");
            Console.WriteLine();

            // Get deck name from user and create new deck object
            Console.WriteLine("Type in a name for the new deck: ");
            Console.Write("Deck Name: ");
            string userInputDeckName = Console.ReadLine();
            return userInputDeckName;
        }

        public static void IncorrectSelectionMenu()
        {
            Console.WriteLine("No choice selected. Please try again.\n");
        }

        public static void ExitProgram()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("====================================================");
            Console.WriteLine("    Thanks for trying out Henry's Flash Card App!   ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
        }
    }
}
