using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Lumpy Space Princess", "How to Cook Beans", 60);
        video1.SetComment(new Comment("Billy", "Beans are my favorite!"));
        video1.SetComment(new Comment("Timmy", "Beans are GROSS!"));
        video1.SetComment(new Comment("Suzy", "That is my favorite way to cook beans."));
        video1.SetComment(new Comment("Jimmy", "Bleep blop, I am a bot."));
        videos.Add(video1);

        Video video2 = new Video("Finn", "How to Save a Princess", 300);
        video2.SetComment(new Comment("Jake", "Amazing hero technique!"));
        video2.SetComment(new Comment("Slime Princess", "Than you for rescuing me Finn!"));
        video2.SetComment(new Comment("Tiffany", "I could have saved that princess way better."));
        video2.SetComment(new Comment("Breakfast Princes", "Poor Slime Princess! I am glad you were able to save her."));
        videos.Add(video2);

        Video video3 = new Video("Ice King", "How to Kidnap a Princess", 60);
        video3.SetComment(new Comment("Jake", "Ice King! Stop kidnapping princesses"));
        video3.SetComment(new Comment("Hotdog Princess Princess", "Finn will find you!"));
        video3.SetComment(new Comment("Gunter", "Wenk"));
        videos.Add(video3);

        Video video4 = new Video("Jake", "How to be a Magical Dog", 60);
        video4.SetComment(new Comment("Lady Rainicorn", "You are so magical Jake."));
        video4.SetComment(new Comment("Tree Trunks", "You and Finn should come over and have some of my fresh baked apple pie."));
        video4.SetComment(new Comment("Tiffany", "Stop hanging out with Finn."));
        video4.SetComment(new Comment("MeMow", "I will get you Jake!"));
        videos.Add(video4);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetVideo()} Comments: {video.GetCommentCount()} \n");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetComment()}");
            }
            Console.WriteLine("\n");
        }


    }
}