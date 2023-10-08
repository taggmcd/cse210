using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int selection = -1;
        Journal journal = new Journal();

        while (selection != 5)
        {
            Console.WriteLine("Welcome to Your Journal");
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Load: ");
            Console.WriteLine("2. Write: ");
            Console.WriteLine("3. Display: ");
            Console.WriteLine("4. Save: ");
            Console.WriteLine("5. Quit: ");
            Console.Write("What would you like to do? ");
            var input = Console.ReadLine();
            bool parseSuccess = int.TryParse(input, out int validSelection);

            if (parseSuccess)
            {
                selection = validSelection;
            }

            if (selection == 1)
            {
                journal.LoadEntries();
                Console.WriteLine("Journal loaded!\n");
            }
            else if (selection == 2)
            {
                journal.AddEntry();

            }
            else if (selection == 3)
            {
                journal.DisplayEntries();

            }
            else if (selection == 4)
            {
                journal.SaveEntries();
                Console.WriteLine("Journal saved!\n");

            }
        }
    }

}