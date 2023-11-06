using System.Reflection;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflections = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string _prompt;
    private List<string> shuffledList;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompt = _prompts[new Random().Next(_prompts.Count())];
    }
    public void ShowPrompt()
    {
        Console.WriteLine($"{_prompt}");
    }

    public void Run()
    {
        shuffledList = _reflections.OrderBy(i => Guid.NewGuid()).ToList();
        long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();


        foreach (string reflection in _reflections)
        {
            if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() > timestamp + GetTimeLimit())
            {
                break;
            }

            Console.WriteLine($"{reflection}");
            DisplaySpinner(10);
        }
    }
}
