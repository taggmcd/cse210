class Activity
{
    protected string _name;
    protected string _description;
    protected int _timeLimit;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplaySpinner(int timeLimit)
    {

        int counter = 0;
        long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        while (DateTimeOffset.UtcNow.ToUnixTimeSeconds() < timestamp + timeLimit)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(250);
        }
    }
    public void DisplayCountdown(int timeLimit)
    {

        while (timeLimit > 0)
        {
            Console.Write($"\rTime Remaining {timeLimit} ");
            timeLimit--;
            Thread.Sleep(1000);
        }
    }
    public void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("Please enter how many seconds you would like the activity to last? ");
        _timeLimit = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEnd()
    {
        Console.Clear();
        Console.WriteLine($"Great job, you just completed {GetTimeLimit()} seconds of the {_name}");
        DisplaySpinner(10);
    }

    public int GetTimeLimit()
    {
        return _timeLimit;
    }
}