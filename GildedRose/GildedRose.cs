using System.Collections.Generic;

namespace GildedRoseKata;
    public class GildedRose { 
        private readonly IList<Item> _items;
        public GildedRose(IList<Item> items) { 
            _items = items;
        }
        public void UpdateQuality() { 
            foreach (var item in _items) {
                var itemUpdater = ItemUpdaterFactory.GetItemUpdater(item); 
                itemUpdater.UpdateQuality(item);
                UpdateSellIn(item);
                if (item.SellIn < 0) { 
                    itemUpdater.UpdateExpiredQuality(item); 
                }
            }
        }
        private void UpdateSellIn(Item item) { 
            if (item.Name != "Sulfuras, Hand of Ragnaros") { 
                item.SellIn--; 
            }
        }
    }