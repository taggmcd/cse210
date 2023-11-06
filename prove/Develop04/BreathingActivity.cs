class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        while (DateTimeOffset.UtcNow.ToUnixTimeSeconds() < timestamp + GetTimeLimit())
        {
            Console.WriteLine("\nBreathe in.");
            this.DisplayCountdown(4);

            Console.WriteLine("\nHold ");
            this.DisplayCountdown(6);

            Console.WriteLine("\nBreathe out. ");
            this.DisplayCountdown(8);
        }
    }
}