namespace GildedRoseKata;
    public interface IItemUpdater
    {
        void UpdateQuality(Item item);
        void UpdateExpiredQuality(Item item);
    }