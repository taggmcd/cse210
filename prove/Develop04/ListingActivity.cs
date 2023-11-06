class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _prompt;
    private int _answerCount;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompt = _prompts[new Random().Next(_prompts.Count())];
    }

    public void GetAnswers()
    {
        Console.ReadLine();
    }

    public void IncrementAnswerCount()
    {
        _answerCount++;
    }

    public int GetAnswerCount()
    {
        return _answerCount;
    }

    public void Run()
    {
        Console.WriteLine($"{_prompt}");
        DisplayCountdown(10);

        long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        while (DateTimeOffset.UtcNow.ToUnixTimeSeconds() < timestamp + GetTimeLimit())
        {
            Console.Write("Enter item: ");
            GetAnswers();
            IncrementAnswerCount();
        }

        Console.WriteLine($"Time is up, you entered {GetAnswerCount()} items");
        DisplaySpinner(10);
    }

}