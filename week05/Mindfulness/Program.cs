using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program keeps track of how many mindfulness
        // activities the user completes during the current session
        // and displays the total when the user quits.
        int activitiesCompleted = 0;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                activitiesCompleted++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                activitiesCompleted++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                activitiesCompleted++;
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine($"You completed {activitiesCompleted} activities this session.");
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                break;
            }
        }
    }
}