namespace GildedRoseKata;
    public abstract class BaseItemUpdater : IItemUpdater
    {
        public abstract void UpdateQuality(Item item);
        public virtual void UpdateExpiredQuality(Item item)
        {
            UpdateQuality(item);
        }
    }
