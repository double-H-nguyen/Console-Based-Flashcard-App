using System;

namespace FlashCardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckCollection.PreMadeDeck();

            while (true)
            {
                // Initialize variables
                bool exit = false;
                int userChoice;
                string userInput;

                // Display menu and store userInput
                userChoice = Menu.CollectionMenu();

                // Execute user's choice
                switch (userChoice)
                {
                    // Select Deck
                    case 1:
                        // Get deck
                        Deck deckObj = Menu.SelectDeckMenu();

                        // Execute action
                        userChoice = Menu.SelectDeckActionMenu(deckObj);
                        switch (userChoice)
                        {
                            // Study Deck
                            case 1:
                                userChoice = Menu.StudyDeckMenu(deckObj);
                                switch (userChoice)
                                {
                                    // Study in original order
                                    case 1:
                                        deckObj.OriginalOrder();
                                        break;
                                    // Study in shuffle mode
                                    case 2:
                                        deckObj.Shuffle();
                                        break;
                                    default:
                                        Menu.IncorrectSelectionMenu();
                                        break;
                                }
                                break;
                            // Edit Deck
                            case 2:
                                userChoice = Menu.EditDeckMenu(deckObj);
                                switch (userChoice)
                                {
                                    // Edit deck name
                                    case 1:
                                        userInput = Menu.EditDeckNameMenu();
                                        deckObj.EditDeckName(userInput);
                                        break;
                                    // Edit flashcard
                                    case 2:
                                        // Get flashcard
                                        Flashcard flashcardObj = Menu.SelectFlashcardMenu(deckObj);

                                        // Select action
                                        userChoice = Menu.SelectFlashcardActionMenu(flashcardObj);
                                        switch (userChoice)
                                        {
                                            // Edit front card
                                            case 1:
                                                userInput = Menu.EditFrontCardMenu();
                                                flashcardObj.EditFrontCard(userInput);
                                                break;
                                            // Edit back card
                                            case 2:
                                                userInput = Menu.EditBackCardMenu();
                                                flashcardObj.EditBackCard(userInput);
                                                break;
                                            // Remove card
                                            case 3:
                                                deckObj.RemoveFlashcard(flashcardObj);
                                                break;
                                            default:
                                                Menu.IncorrectSelectionMenu();
                                                break;
                                        }
                                        break;
                                    // Add flashcard
                                    case 3:
                                        // newFlashcard[0] = front, newFlashcard[1] = back
                                        string[] newFlashcard = new string[2];
                                        newFlashcard = Menu.AddFlashcardMenu();
                                        deckObj.AddFlashcard(newFlashcard[0], newFlashcard[1]);
                                        break;
                                    default:
                                        Menu.IncorrectSelectionMenu();
                                        break;
                                }
                                break;
                            // Remove Deck
                            case 3:
                                DeckCollection.RemoveDeck(deckObj);
                                break;
                            default:
                                Menu.IncorrectSelectionMenu();
                                break;
                        }
                        break;
                    // Add deck
                    case 2:
                        string newDeckName = Menu.AddDeckMenu();
                        DeckCollection.AddDeck(newDeckName);
                        break;
                    // Exit program
                    case 3:
                        exit = true;
                        break;
                    default:
                        Menu.IncorrectSelectionMenu();
                        break;
                }

                if (exit)
                {
                    Menu.ExitProgram();
                    break;
                }
                Console.WriteLine("\n\n\n\n");
            }
        }
    }
}
