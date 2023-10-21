using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> scriptures = new Dictionary<string, string>(){
        {"Mosiah 4:7", "I say, that this is the man who receiveth salvation, through the atonement which was prepared from the foundation of the world for all mankind, which ever were since the fall of Adam, or who are, or who ever shall be, even unto the end of the world."},
        {"Moroni 10:3-4", "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.\n And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."},
        {"Moroni 10:5","And by the power of the Holy Ghost ye may know the truth of all things."}
        };
        int selector = new Random().Next(scriptures.Count());
        bool lastRun = false;
        string reference = scriptures.ElementAt(selector).Key;
        string scriptureText = scriptures.ElementAt(selector).Value;

        Scripture scripture = new Scripture(reference, scriptureText);


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Text());
            Console.WriteLine("Press enter to hide a word or type 'quit to exit: ");

            if (scripture.AllHidden() && lastRun)
            {
                break;
            }
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandom();

            if (scripture.AllHidden() && !lastRun)
            {
                lastRun = true;
            }

        }
    }
}