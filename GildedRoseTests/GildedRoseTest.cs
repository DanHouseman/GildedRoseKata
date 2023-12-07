using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void UpdateQuality_RegularItem_QualityDecreases()
    {
        var regularItem = new Item { Name = "Regular Item", SellIn = 5, Quality = 10 };
        var items = new List<Item> { regularItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(9, regularItem.Quality);
    }
    [Test]
    public void UpdateQuality_RegularItem_SellInDecreases()
    {
        var regularItem = new Item { Name = "Regular Item", SellIn = 5, Quality = 10 };
        var items = new List<Item> { regularItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(4, regularItem.SellIn);
    }
    [Test]
    public void UpdateQuality_AgedBrie_QualityIncreases()
    {
        var agedBrie = new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 };
        var items = new List<Item> { agedBrie };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(11, agedBrie.Quality);
    }
    [Test]
    public void UpdateQuality_AgedBrie_MaxQualityDoesNotExceed50()
    {
        var agedBrie = new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 };
        var items = new List<Item> { agedBrie };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(50, agedBrie.Quality);
    }
    [Test]
    public void UpdateQuality_BackstagePass_QualityIncreases()
    {
        var backstagePass =
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 10
            };
        var items = new List<Item> { backstagePass };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(11, backstagePass.Quality);
    }
    [Test]
    public void UpdateQuality_BackstagePass_QualityIncreasesBy2Within10Days()
    {
        var backstagePass =
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 10
            };
        var items = new List<Item> { backstagePass };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(12, backstagePass.Quality);
    }
    [Test]
    public void UpdateQuality_BackstagePass_QualityIncreasesBy3Within5Days()
    {
        var backstagePass =
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 10
            };
        var items = new List<Item> { backstagePass };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(13, backstagePass.Quality);
    }
    [Test]
    public void UpdateQuality_BackstagePass_QualityDropsToZeroAfterConcert()
    {
        var backstagePass =
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 10
            };
        var items = new List<Item> { backstagePass };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(0, backstagePass.Quality);
    }
    [Test]
    public void UpdateQuality_ConjuredItem_QualityDecreasesTwiceAsFast()
    {
        var conjuredItem = new Item { Name = "Conjured", SellIn = 5, Quality = 10 };
        var items = new List<Item> { conjuredItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(8, conjuredItem.Quality);
    }
    [Test]
    public void UpdateQuality_Sulfuras_QualityDoesNotChange()
    {
        var sulfuras = new Item
        {
            Name = "Sulfuras, Hand of Ragnaros",
            SellIn = 5,
            Quality = 10
        };
        var items = new List<Item> { sulfuras };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(10, sulfuras.Quality);
    }
    [Test]
    public void UpdateQuality_Sulfuras_SellInDoesNotChange()
    {
        var sulfuras = new Item
        {
            Name = "Sulfuras, Hand of Ragnaros",
            SellIn = 5,
            Quality = 10
        };
        var items = new List<Item> { sulfuras };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(5, sulfuras.SellIn);
    }
    [Test]
    public void UpdateQuality_ExpiredItem_QualityDecreasesTwiceAsFast()
    {
       Item regularItem = new Item { Name = "Regular Item", SellIn = -1, Quality = 10 };
       var items = new List<Item> { regularItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(8, regularItem.Quality);
    }
    [Test]
    public void UpdateQuality_MinimumQualityIsZero()
    {
        var regularItem = new Item { Name = "Regular Item", SellIn = 5, Quality = 0 };
        var items = new List<Item> { regularItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(0, regularItem.Quality);
    }
    [Test]
    public void UpdateQuality_MinimumSellInIsZero()
    {
        var regularItem =
            new Item { Name = "Regular Item", SellIn = 0, Quality = 10 };
        var items = new List<Item> { regularItem };
        var gildedRose = new GildedRoseKata.GildedRose(items);
        gildedRose.UpdateQuality();
        Assert.AreEqual(-1, regularItem.SellIn);
    }  

}