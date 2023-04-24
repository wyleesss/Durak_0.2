class Achivements
{
    public string name { get; }
    public long award_money { get; }
    public int golden_cards { get; }
    public string type { get; }
    public string game { get; }

    public Achivements(string name, long award_money, int golden_cards,
                       string type, string game)
    {
        this.name = name;
        this.award_money = award_money;
        this.golden_cards = golden_cards;
        this.type = type;
        this.game = game;
    }
}

class SpecialAbilities
{
    string name { get; }
    string type { get; }

    public SpecialAbilities(string name, string type)
    {
        this.name = name;
        this.type = type;
    }
    public void to_do() { /* нема */ }
}

class Shirt { } // <-- я пропоную це видалити нахуй (1)

internal class User
{
    public int id { get; }
    public string user_name { get; set; }
    public string login { get; }
    public string password { get; set; }
    public string gmail { get; set; }

    public long durak_b { get; set; }
    public long black_jack_b { get; set; }

    public int golden_cards { get; set; }

    List<Shirt> shirts = new();
    List<Achivements> achives = new();
    List<SpecialAbilities> sa = new();

    public User(int id, string user_name, string login, string password, string gmail,
                long durak_b, long black_jack_b, int golden_cards,
                List<Shirt> shirts, List<Achivements> achives, List<SpecialAbilities> sa)
    {
        this.id = id;
        this.user_name = user_name;
        this.login = login;
        this.password = password;
        this.gmail = gmail;
        this.durak_b = durak_b;
        this.black_jack_b = black_jack_b;
        this.golden_cards = golden_cards;
        this.shirts = shirts;
        this.achives = achives;
        this.sa = sa;
    }
}

class Card
{
    string skin; // <-- я пропоную це видалити нахуй (2)
    char suit { get; }
    int number { get; }

    public Card(int number, char suit)
    {
        this.number = number;
        this.suit = suit;
    }
}

internal struct StaticCards
{
    public static List<Card> koloda_24 = new() { /* нема */ };
    public static List<Card> koloda_36 = new() { /* нема */ };
    public static List<Card> koloda_54 = new() { /* нема */ };
}

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("");
    }
}