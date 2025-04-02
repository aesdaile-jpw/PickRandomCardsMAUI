namespace PickRandomCards;

class CardPicker
{
    /// <summary>
    /// Picks a number of cards from a deck
    /// </summary>
    /// <param name="numberOfCards"></param>
    /// <returns></returns>
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        List<string> cardDeck = new List<string>();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                cardDeck.Add(rank + " of " + suit);
            }
        }

        for (int i = 0;  i < numberOfCards; i++)
        {
            // pickedCards[i] = RandomValue() + " of " + RandomSuit();
            int value = Random.Shared.Next(cardDeck.Count);
            pickedCards[i] = cardDeck[value];
            cardDeck.RemoveAt(value);
        }
        return pickedCards;
    }
    /// <summary>
    /// Returns a random suit
    /// </summary>
    /// <returns></returns>
    private static string RandomSuit()
    {
        int value = Random.Shared.Next(1, 5);   // pick a random number from 1 to 4
        if (value == 1) return "Spades";
        if (value == 2) return "Hearts";
        if (value == 3) return "Clubs";
        return "Diamonds";
    }

    /// <summary>
    /// Returns a random value
    /// </summary>
    /// <returns></returns>
    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);  // pick a random number from 1 to 13
        if (value == 1) return "Ace";
        if (value == 11) return "Jack";
        if (value == 12) return "Queen";
        if (value == 13) return "King";
        return value.ToString();
    }

   

}
