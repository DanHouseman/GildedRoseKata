namespace GildedRoseKata;

public class ConjuredItemUpdater : BaseItemUpdater
{
    public override void UpdateQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 2;
        }
    }
}
