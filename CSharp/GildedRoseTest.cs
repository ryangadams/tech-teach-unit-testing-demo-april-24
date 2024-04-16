using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void QualityReducesWithAge()
        {
            // Arrange
            Item item = new Item { Name = "Standard", SellIn = 10, Quality = 30 };
            GildedRose app = new GildedRose([item]);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(29, item.Quality);
        }
        
        [Test]
        public void QualityReducesFasterAfterSellIn()
        {
            // Arrange
            Item item = new Item { Name = "Standard", SellIn = 0, Quality = 30 };
            GildedRose app = new GildedRose([item]);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(28, item.Quality);
        }
        
        [Test]
        public void QualityIsNeverLessThanZero()
        {
            Item item = new Item { Name = "Standard", SellIn = 0, Quality = 0 };
            GildedRose app = new GildedRose([item]);
            
            app.UpdateQuality();
            
            Assert.AreEqual(0, item.Quality);
        }
        
        [Test]
        public void AgedBrieGetsBetterWithAge()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 };
            GildedRose app = new GildedRose([item]);
            
            app.UpdateQuality();
            
            Assert.AreEqual(11, item.Quality);
        }
        
        [Test]
        public void QualityIsNeverOverFifty()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 };
            GildedRose app = new GildedRose([item]);
            
            app.UpdateQuality();
            
            Assert.AreEqual(50, item.Quality);
        }
        
        [Test]
        public void QualityGetsBetterFasterAfterSellIn()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 };
            GildedRose app = new GildedRose([item]);
            
            app.UpdateQuality();
            
            Assert.AreEqual(12, item.Quality);
        }
        
        [Test]
        public void SulfurasNeverChanges()
        {
            Item item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 80, Quality = 80 };
            GildedRose app = new GildedRose([item]);
            
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(80, item.Quality);
            Assert.AreEqual(80, item.SellIn);
        }
        
        [Test]
        public void BackStagePassesQualityProperties()
        {
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 };
            GildedRose app = new GildedRose([item]);
            
            // THIS IS REALLY UGLY AND IT SHOULD BE FIXED
            app.UpdateQuality();
            Assert.AreEqual(11, item.Quality);
            app.UpdateQuality();
            Assert.AreEqual(13, item.Quality);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(21, item.Quality);
            app.UpdateQuality();
            Assert.AreEqual(24, item.Quality);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(36, item.Quality);
            app.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
        }
    }
}
