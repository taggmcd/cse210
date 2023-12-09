class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Lecture", "The 4th Dimension", "Finn will discuss how the 4th dimension works.", "01-01-2024", "13:00", new Address("1 Cougar Way", "Provo", "Utah", "USA"), "Finn the Human", 20);
        Reception reception = new Reception("Reception", "Heather and Tagg Reception", "Heather and Tagg got married come celebrate!", "12-30-2023", "14:00", new Address("Cedar Hill Golf Course Club House", "Cedar Hills", "Utah", "USA"), true, "bleepblop@bitbandit.net");
        Outdoor outdoor = new Outdoor("Outdoor", "Summer Concert in the Park", "Come listen to some local bands in the park!", "07-01-2024", "20:00", new Address("Vetrans Memorial Park", "Pleasant Grove", "Utah", "USA"), "Clear Skys");


        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event item in events)
        {

            Console.WriteLine("--------------- Standard Details ---------------");
            Console.WriteLine($"Title: {item.GetTitle()}");
            Console.WriteLine($"Description: {item.GetDescription()}");
            Console.WriteLine($"Date and Time: {item.GetDate()} @ {item.GetTime()}");
            Console.WriteLine($"Location: {item.GetAddress()}\n");

            Console.WriteLine("\n--------------- Full Details ---------------");
            Console.WriteLine($"Title: {item.GetTitle()}");
            Console.WriteLine($"Type: {item.GetType()}");
            Console.WriteLine($"Description: {item.GetDescription()}");
            Console.WriteLine($"Date and Time: {item.GetDate()} @ {item.GetTime()}");
            Console.WriteLine($"Location: {item.GetAddress()}");

            if (item.GetEventType() == "Lecture")
            {
                Lecture l = (Lecture)item;
                Console.WriteLine($"Speaker: {l.GetSpeaker()}");
                Console.WriteLine($"Capacity: {l.GetCapacity()}");
            }
            else if (item.GetEventType() == "Reception")
            {
                Reception r = (Reception)item;
                Console.WriteLine($"RSVP Required: {r.MustRegister()}");
                Console.WriteLine($"RSVP Contact: {r.GetEmail()}");
            }
            else if (item.GetEventType() == "Outdoor")
            {
                Outdoor o = (Outdoor)item;
                Console.WriteLine($"Weather: {o.GetWeather()}");
            }

            Console.WriteLine("\n--------------- Short Details ---------------");
            Console.WriteLine($"{item.GetTitle()} | {item.GetType()} | {item.GetDate()}\n");
        }
    }
}