namespace MyMonkeyApp;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
            Population = 10000,
            Latitude = -8.783195,
            Longitude = 34.508523
        },
        new Monkey
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. They are readily identified as the 'organ grinder' monkey.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
            Population = 23000,
            Latitude = -6.471944,
            Longitude = -76.985278
        },
        new Monkey
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg",
            Population = 12000,
            Latitude = -3.282778,
            Longitude = 40.116667
        },
        new Monkey
        {
            Name = "Squirrel Monkey",
            Location = "Central & South America",
            Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimiriinae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/squirrelmonkey.jpg",
            Population = 11000,
            Latitude = -2.153889,
            Longitude = -74.948889
        },
        new Monkey
        {
            Name = "Golden Lion Tamarin",
            Location = "Brazil",
            Details = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/goldenlion.jpg",
            Population = 1000,
            Latitude = -22.785278,
            Longitude = -42.473056
        },
        new Monkey
        {
            Name = "Howler Monkey",
            Location = "South America",
            Details = "Howler monkeys are among the largest of the New World monkeys. They are famous for their loud howls.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/howler.jpg",
            Population = 8000,
            Latitude = -13.383333,
            Longitude = -61.916667
        },
        new Monkey
        {
            Name = "Japanese Macaque",
            Location = "Japan",
            Details = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes referred to as the snow monkey.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/japanesemacque.jpg",
            Population = 114000,
            Latitude = 36.566667,
            Longitude = 138.2
        },
        new Monkey
        {
            Name = "Mandrill",
            Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
            Details = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/mandrill.jpg",
            Population = 7000,
            Latitude = -2.066667,
            Longitude = 9.65
        },
        new Monkey
        {
            Name = "Proboscis Monkey",
            Location = "Borneo",
            Details = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/proboscis.jpg",
            Population = 7000,
            Latitude = 1.533333,
            Longitude = 110.4
        },
        new Monkey
        {
            Name = "Red-shanked douc",
            Location = "Vietnam, Laos",
            Details = "The red-shanked douc is a species of Old World monkey, among the most colourful of all primates.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/redshanked.jpg",
            Population = 1300,
            Latitude = 16.0,
            Longitude = 108.0
        },
        new Monkey
        {
            Name = "Gray-shanked douc",
            Location = "Vietnam",
            Details = "The gray-shanked douc langur is a douc species native to the Vietnamese provinces.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/grayshanked.jpg",
            Population = 550,
            Latitude = 15.190278,
            Longitude = 108.3475
        },
        new Monkey
        {
            Name = "Golden Snub-nosed Monkey",
            Location = "China",
            Details = "The golden snub-nosed monkey is an Old World monkey in the Colobinae subfamily. It is endemic to a small area in temperate, mountainous forests of central and Southwest China.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/golden.jpg",
            Population = 10000,
            Latitude = 33.5,
            Longitude = 109.5
        },
        new Monkey
        {
            Name = "Black Snub-nosed Monkey",
            Location = "China",
            Details = "The black snub-nosed monkey, also known as the Yunnan snub-nosed monkey, is an endangered species of primate in the family Cercopithecidae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/blacksnub.jpg",
            Population = 2000,
            Latitude = 26.816667,
            Longitude = 99.183333
        },
        new Monkey
        {
            Name = "Tonkin Snub-nosed Monkey",
            Location = "Vietnam",
            Details = "The Tonkin snub-nosed monkey or Dollman's snub-nosed monkey is a slender-bodied arboreal Old World monkey, endemic to northern Vietnam.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/tonkin.jpg",
            Population = 250,
            Latitude = 22.4,
            Longitude = 105.416667
        },
        new Monkey
        {
            Name = "Thomas's langur",
            Location = "Indonesia",
            Details = "Thomas's langur is a species of primate in the family Cercopithecidae. It is endemic to North Sumatra, Indonesia.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/thomaslangur.jpg",
            Population = 11000,
            Latitude = 2.916667,
            Longitude = 98.5
        },
        new Monkey
        {
            Name = "Purple-faced Langur",
            Location = "Sri Lanka",
            Details = "The purple-faced langur, also known as the purple-faced leaf monkey, is a species of Old World monkey that is endemic to Sri Lanka.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/purplefaced.jpg",
            Population = 5000,
            Latitude = 7.873611,
            Longitude = 80.771667
        },
        new Monkey
        {
            Name = "Gelada",
            Location = "Ethiopia",
            Details = "The gelada, sometimes called the bleeding-heart monkey, is a species of Old World monkey found only in the Ethiopian Highlands.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/gelada.jpg",
            Population = 200000,
            Latitude = 12.5,
            Longitude = 38.5
        }
    };

    private static int randomAccessCount = 0;
    private static readonly Random random = new();

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    /// <returns>A read-only list of all monkeys.</returns>
    public static IReadOnlyList<Monkey> GetMonkeys()
    {
        return monkeys.AsReadOnly();
    }

    /// <summary>
    /// Gets a random monkey from the collection.
    /// </summary>
    /// <returns>A randomly selected monkey.</returns>
    public static Monkey GetRandomMonkey()
    {
        randomAccessCount++;
        var index = random.Next(monkeys.Count);
        return monkeys[index];
    }

    /// <summary>
    /// Finds a monkey by name (case-insensitive).
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey with the specified name, or null if not found.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets the count of how many times a random monkey has been accessed.
    /// </summary>
    /// <returns>The access count for random monkey requests.</returns>
    public static int GetRandomAccessCount()
    {
        return randomAccessCount;
    }
}
