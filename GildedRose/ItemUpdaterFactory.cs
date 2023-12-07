namespace GildedRoseKata;
    public static class ItemUpdaterFactory
    {
        public static IItemUpdater GetItemUpdater(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                return new AgedBrieUpdater();
            }
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePassUpdater();
            }
            if (item.Name == "Conjured")
            {
                return new ConjuredItemUpdater();
            }
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasItemUpdater();
            }
            return new RegularItemUpdater();
        }
    }