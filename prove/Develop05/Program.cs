// I wrote a couple funstions to create a simple goal level system. for very 5 goals that are completed the user will gain a goal level
// Functions written setGoalLevel() and completedGoals()
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string fileName = "goals.txt";
        int totalPoints;
        int goalLevel;
        int selection = 0;
        string input;
        string name;
        string description;
        int pointValue;
        int targetCount;
        int bonusValue;
        string completed;
        int goalSelect;

        Goal simpleGoal;
        Goal eternalGoal;
        Goal checklistGoal;

        List<Goal> goalList = new List<Goal>();

        while (selection != 6)
        {
            totalPoints = 0;
            setGoalLevel(completedGoals());
            foreach (Goal goal in goalList)
            {
                totalPoints += goal.GetPoints();
            }

            selection = 0;
            Console.Clear();
            Console.WriteLine($"You have {totalPoints} points and have a goal level of {goalLevel}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = GetInt();

            if (selection == 1)
            {
                while (selection != 4)
                {
                    selection = 0;
                    Console.Clear();
                    Console.WriteLine($"You have {totalPoints} points.");
                    Console.WriteLine("Menu Options:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goals");
                    Console.WriteLine("  3. Checklist Goals");
                    Console.WriteLine("  4. Back");
                    Console.Write("Select a choice from the menu: ");
                    selection = GetInt();

                    if (selection == 1)
                    {
                        Console.Write("What would you like to name this goal? ");
                        name = Console.ReadLine();

                        Console.Write("Short description of this goal? ");
                        description = Console.ReadLine();

                        Console.Write("How many points is this goal worth when completed? ");
                        pointValue = GetInt();
                        simpleGoal = new SimpleGoal(name, description, pointValue);
                        goalList.Add(simpleGoal);

                    }
                    else if (selection == 2)
                    {
                        Console.Write("What would you like to name this goal? ");
                        name = Console.ReadLine();

                        Console.Write("Short description of this goal? ");
                        description = Console.ReadLine();

                        Console.Write("How many points is this goal worth each time it is done? ");
                        pointValue = GetInt();
                        eternalGoal = new EternalGoal(name, description, pointValue);
                        goalList.Add(eternalGoal);

                    }
                    else if (selection == 3)
                    {
                        Console.Write("What would you like to name this goal? ");
                        name = Console.ReadLine();

                        Console.Write("Short description of this goal? ");
                        description = Console.ReadLine();

                        Console.Write("How many points is this goal worth when completed? ");
                        bonusValue = GetInt();

                        Console.Write("How many do you want this goal to happen? ");
                        targetCount = GetInt();

                        Console.Write("How many points is this goal worth each time it is done? ");
                        pointValue = GetInt();

                        checklistGoal = new ChecklistGoal(name, description, pointValue, targetCount, bonusValue);
                        goalList.Add(checklistGoal);
                    }
                }
            }
            else if (selection == 2)
            {
                listGoals(goalList);
                Console.WriteLine("\npress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (selection == 3)
            {
                Console.Clear();
                Console.WriteLine("Saving Goals...");
                saveGoals(goalList);
                Console.WriteLine("Goals Saved!");
            }
            else if (selection == 4)
            {
                Console.Clear();
                Console.WriteLine("Loading Goals...");
                loadGoals();
                Console.WriteLine("Goals Loaded!");
            }
            else if (selection == 5)
            {
                Console.Clear();
                listGoals(goalList);
                Console.WriteLine("Which goal would you like to record? ");
                goalSelect = GetInt();
                goalList[goalSelect - 1].Record();
                Console.WriteLine("Goal recorded");
                Console.WriteLine("\npress any key to return to the menu...");
                Console.ReadKey();
            }
        }


        int GetInt()
        {
            input = Console.ReadLine();
            bool parseSuccess = int.TryParse(input, out int validInt);

            if (parseSuccess)
            {
                return validInt;
            }
            else
            {
                return -1;
            }
        }

        void listGoals(List<Goal> goals)
        {
            int item = 1;

            Console.Clear();
            foreach (Goal goal in goals)
            {
                if (goal.IsCompleted())
                {
                    completed = "[X] ";
                }
                else
                {
                    completed = "[ ] ";
                }
                Console.WriteLine($"{item}. {completed} {goal.PrintGoal()}");
                item++;
            }
        }
        void saveGoals(List<Goal> goals)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.Serialize());
                }
            }
        }

        void loadGoals()
        {
            string[] lines = File.ReadAllLines(fileName);
            goalList.Clear();
            foreach (string line in lines)
            {
                int goalEventCount = 0;
                int goalTartgetCount = 0;
                int goalBonusValue = 0;

                string[] parts = line.Split(",");

                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPointValue = Int32.Parse(parts[3]);
                bool goalCompleted = Boolean.Parse(parts[4]);
                if (parts.Length >= 6)
                {
                    goalEventCount = Int32.Parse(parts[5]);
                }
                if (parts.Length == 8)
                {
                    goalTartgetCount = Int32.Parse(parts[6]);
                    goalBonusValue = Int32.Parse(parts[7]);
                }

                if (goalType == "SimpleGoal")
                {
                    Goal addGoal = new SimpleGoal(goalName, goalDescription, goalPointValue);
                    if (goalCompleted)
                    {
                        addGoal.Record();
                    }
                    addGoal.SetPoints();
                    goalList.Add(addGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    Goal addGoal = new EternalGoal(goalName, goalDescription, goalPointValue);
                    addGoal.SetEventCount(goalEventCount);
                    addGoal.SetPoints();
                    goalList.Add(addGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    Goal addGoal = new ChecklistGoal(goalName, goalDescription, goalPointValue, goalTartgetCount, goalBonusValue);
                    addGoal.SetEventCount(goalEventCount);
                    if (goalCompleted)
                    {
                        addGoal.SetCompleted();
                    }
                    addGoal.SetPoints();
                    goalList.Add(addGoal);
                }
            }
        }

        int completedGoals()
        {
            int completedCount = 0;
            foreach (Goal goal in goalList)
            {
                if (goal.IsCompleted())
                {
                    completedCount++;
                }
            }
            return completedCount;
        }

        void setGoalLevel(int goalCount)
        {
            goalLevel = 1;
            goalLevel += goalCount / 5;

        }
    }
}