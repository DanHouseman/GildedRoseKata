using GildedRose;

namespace GildedRoseKata;

public class ConjuredItemHandler : IConjuredItemHandler
{
    public void HandleConjured(Item item)
    {
        if (item.Name == "Conjured" && item.Quality > 0)
        {
            item.Quality -= 2; // Conjured items degrade twice as fast
        }
    }
}
