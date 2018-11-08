using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardApp
{
    class Flashcard
    {
        public string FrontCard { get; set; } = "No Content";
        public string BackCard { get; set; } = "No Content";

        // Constructor
        public Flashcard (string front, string back)
        {
            FrontCard = front;
            BackCard = back;
            Console.WriteLine("Flashcard has been created with \"{0}\" in the front and \"{1}\" in the back\n", FrontCard, BackCard);
        }

        // Edit front of flashcard
        public void EditFrontCard(string front)
        {
            FrontCard = front;
            Console.WriteLine("Flashcard has been edited with \"{0}\" in the front\n", FrontCard);
        }

        // Edit back of flashcard
        public void EditBackCard(string back)
        {
            BackCard = back;
            Console.WriteLine("Flashcard has been edited with \"{0}\" in the back\n", BackCard);
        }

        // Show both side
        public void ShowBothSides()
        {
            Console.WriteLine("FRONT: \"{0}\", BACK: \"{1}\"", FrontCard, BackCard);
            //ShowFront();
            //ShowBack();
            Console.WriteLine();
        }

        // Show front only
        public void ShowFront()
        {
            Console.WriteLine($"FRONT: \"{FrontCard}\"");
        }

        // Show back only
        public void ShowBack()
        {
            Console.WriteLine($"BACK: \"{BackCard}\"");
        }
    }
}
