namespace GildedRoseKata;

    public class AgedBrieUpdater : BaseItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }

