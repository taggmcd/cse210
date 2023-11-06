using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main(string[] args)
    {
        int selection = -1;
        BreathingActivity breathingActivity;
        ReflectingActivity reflectingActivity;
        ListingActivity listingActivity;

        while (selection != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to The Mindfulness Program");
            Console.WriteLine("Please choose and activity:");
            Console.WriteLine("1. Breathing Activy: ");
            Console.WriteLine("2. Reflection Activty: ");
            Console.WriteLine("3. Listing Activity: ");
            Console.WriteLine("4. Quit: ");
            Console.Write("What would you like to do? ");
            var input = Console.ReadLine();
            bool parseSuccess = int.TryParse(input, out int validSelection);

            if (parseSuccess)
            {
                selection = validSelection;
            }

            if (selection == 1)
            {
                breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.DisplayStart();
                breathingActivity.DisplaySpinner(5);
                breathingActivity.Run();
                breathingActivity.DisplayEnd();

            }
            else if (selection == 2)
            {
                reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.DisplayStart();
                reflectingActivity.DisplaySpinner(5);
                reflectingActivity.ShowPrompt();
                Console.Write("Press enter when you are ready to begin");
                Console.ReadLine();
                reflectingActivity.Run();
                reflectingActivity.DisplayEnd();

            }
            else if (selection == 3)
            {
                listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                listingActivity.DisplayStart();
                listingActivity.DisplaySpinner(5);
                Console.Write("Press enter when you are ready to begin");
                Console.ReadLine();
                listingActivity.Run();
                listingActivity.DisplayEnd();
            }

        }
    }
}