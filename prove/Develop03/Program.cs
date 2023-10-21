using System;

class Program
{
    static void Main(string[] args)
    {
        // string scriptureOneRef = "Mosiah 4:7";
        // string scriptureOneText = "I say, that this is the man who receiveth salvation, through the atonement which was prepared from the foundation of the world for all mankind, which ever were since the fall of Adam, or who are, or who ever shall be, even unto the end of the world.";
        // Scripture scripture = new Scripture(scriptureOneRef, scriptureOneText);

        string scriptureTwoRef = "Moroni 10:3-4";
        string scriptureTwoText = "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.\n And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";
        Scripture scripture = new Scripture(scriptureTwoRef, scriptureTwoText);


        while (!scripture.AllHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Text());
            Console.WriteLine("Press enter to hide a word or type 'quit to exit: ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandom();

        }
    }
}