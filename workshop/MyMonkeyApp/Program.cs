using MyMonkeyApp;

/// <summary>
/// Main program class for the Monkey Console Application.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            var choice = Console.ReadLine();
            
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    exit = true;
                    DisplayGoodbyeMessage();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            
            if (!exit)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    /// <summary>
    /// Displays the welcome message with ASCII art.
    /// </summary>
    static void DisplayWelcomeMessage()
    {
        Console.Clear();
        var artIndex = new Random().Next(3);
        
        switch (artIndex)
        {
            case 0:
                Console.WriteLine(@"
    __,__
   /  .  \
  |\_/|   |
  |   |  /|
   \  '-' /
    '----'
   MONKEY APP
");
                break;
            case 1:
                Console.WriteLine(@"
      .--.  .--.
     /    \/    \
    | .-.  .-.   |
    |/_  |/_  |  |
    || `\|| `\|  |
    |\__/|\__/| /
     \__/  \__//
   MONKEY APP
");
                break;
            case 2:
                Console.WriteLine(@"
        .=""=.
      _/.-.-.\_
     ( ( o o ) )
      |/  ""  \|
       \'---'/
       /`---`\
   MONKEY APP
");
                break;
        }
        
        Console.WriteLine("Welcome to the Monkey Information System!");
        Console.WriteLine("==========================================\n");
    }

    /// <summary>
    /// Displays the main menu options.
    /// </summary>
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select an option:");
        Console.WriteLine("1. List all monkeys");
        Console.WriteLine("2. Get details for a specific monkey by name");
        Console.WriteLine("3. Get a random monkey");
        Console.WriteLine("4. Exit app");
        Console.Write("\nYour choice: ");
    }

    /// <summary>
    /// Lists all available monkeys with their details.
    /// </summary>
    static void ListAllMonkeys()
    {
        Console.WriteLine("=== All Monkeys ===\n");
        
        var monkeys = MonkeyHelper.GetMonkeys();
        
        foreach (var monkey in monkeys)
        {
            DisplayMonkeyDetails(monkey);
            Console.WriteLine(new string('-', 60));
        }
        
        Console.WriteLine($"\nTotal monkeys: {monkeys.Count}");
    }

    /// <summary>
    /// Prompts for a monkey name and displays its details.
    /// </summary>
    static void GetMonkeyByName()
    {
        Console.Write("Enter the monkey name: ");
        var name = Console.ReadLine() ?? string.Empty;
        
        var monkey = MonkeyHelper.GetMonkeyByName(name);
        
        if (monkey != null)
        {
            Console.WriteLine($"\n=== {monkey.Name} Details ===\n");
            DisplayMonkeyDetails(monkey);
        }
        else
        {
            Console.WriteLine($"\nMonkey '{name}' not found.");
            Console.WriteLine("\nAvailable monkeys:");
            var monkeys = MonkeyHelper.GetMonkeys();
            foreach (var m in monkeys)
            {
                Console.WriteLine($"  - {m.Name}");
            }
        }
    }

    /// <summary>
    /// Displays a random monkey with ASCII art.
    /// </summary>
    static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        var accessCount = MonkeyHelper.GetRandomAccessCount();
        
        Console.WriteLine("=== Random Monkey ===\n");
        
        // Display random ASCII art
        var artIndex = new Random().Next(3);
        switch (artIndex)
        {
            case 0:
                Console.WriteLine(@"
    .--.
   |o_o |
   |:_/ |
  //   \ \
 (|     | )
/'\_   _/`\
\___)=(___/
");
                break;
            case 1:
                Console.WriteLine(@"
   @..@
  (----)
 ( >__< )
 ^^  ~~  ^^
");
                break;
            case 2:
                Console.WriteLine(@"
  .='='.
 (._Y_.)
  )    (
 /      \
( (    ) )
 ""      ""
");
                break;
        }
        
        DisplayMonkeyDetails(monkey);
        Console.WriteLine($"\nRandom monkey accessed {accessCount} time(s) total.");
    }

    /// <summary>
    /// Displays detailed information about a monkey.
    /// </summary>
    /// <param name="monkey">The monkey to display.</param>
    static void DisplayMonkeyDetails(Monkey monkey)
    {
        Console.WriteLine($"Name:       {monkey.Name}");
        Console.WriteLine($"Location:   {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population:N0}");
        Console.WriteLine($"Details:    {monkey.Details}");
        Console.WriteLine($"Coordinates: {monkey.Latitude:F6}, {monkey.Longitude:F6}");
        Console.WriteLine($"Image URL:  {monkey.Image}");
    }

    /// <summary>
    /// Displays the goodbye message.
    /// </summary>
    static void DisplayGoodbyeMessage()
    {
        Console.WriteLine(@"
   .--.
  |o_o |     Thanks for using
  |:_/ |     Monkey App!
 //   \ \    
(|     | )   Goodbye!
/'\_   _/`\
\___)=(___/
");
    }
}
