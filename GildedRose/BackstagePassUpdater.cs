namespace GildedRoseKata;

    public class BackstagePassUpdater : BaseItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
                if (item.SellIn < 11 && item.Quality < 50)
                {
                    item.Quality++;
                }
                if (item.SellIn < 6 && item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
        public override void UpdateExpiredQuality(Item item)
        {
            item.Quality = 0;
        }
    }
