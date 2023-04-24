namespace Durak
{
    class Player
    {
        public string name { get; }
        public List<Card> koloda { get; set; } = new();
        public List<SpecialAbilities> sa { get; }
        public bool is_playing { get; set; }

        public Player(string name, List<SpecialAbilities> sa, bool is_playing)
        {
            this.name = name;
            this.sa = sa;
            this.is_playing = is_playing;
        }
    }

    class Game
    {
        Player player; // <-- зробив одного гравця. не бачу сенсу гратися з цілим списком. якщо не згідний - пиши

        List<Card> koloda = new();
        List<Card> rebound = new();

        bool transferable;

        public Game(List<Card> cards_buff, Player player, bool transferable)
        {
            this.player = player;
            this.transferable = transferable;

            Random random = new();
            int random_index;

            while (cards_buff.Count > 0)
            {
                random_index = random.Next(0, cards_buff.Count - 1);

                koloda.Add(cards_buff[random_index]);
                cards_buff.RemoveAt(random_index);
            }
        }

        public void give_cards()
        {
            for (int i = 0; i < 6 - player.koloda.Count; i++)
            {
                player.koloda.Add(koloda[i]);
                koloda.RemoveAt(i);
            }
        }

        public void mixing()
        {
            Random random = new();
            int random_index;

            while (rebound.Count > 0)
            {
                random_index = random.Next(0, rebound.Count - 1);

                koloda.Add(rebound[random_index]);
                rebound.RemoveAt(random_index);
            }
        }
    }
}