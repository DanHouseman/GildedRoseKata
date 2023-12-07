namespace GildedRoseKata;
    public class RegularItemUpdater : BaseItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality--;
            }
        }
    }
