using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; }
    public List<int> Hand { get; }

    public Player(string name)
    {
        Name = name;
        Hand = new List<int>();
    }

    public void AddCard(int card)
    {
        Hand.Add(card);
    }

    public int HandSum()
    {
        return Hand.Sum();
    }
}
