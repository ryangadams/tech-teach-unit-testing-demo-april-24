from gilded_rose import Item, GildedRose


def test_quality_reduces_with_age():
    # Arrange
    item = Item(name="Standard", quality=30, sell_in=10)
    app = GildedRose([item])

    # Act
    app.update_quality()

    # Assert
    assert item.quality == 29


def test_quality_reduces_faster_after_sell_in():
    # Arrange
    item = Item(name="Standard", quality=30, sell_in=0)
    app = GildedRose([item])

    # Act
    app.update_quality()

    # Assert
    assert item.quality == 28


def test_quality_is_never_less_than_zero():
    item = Item(name="Standard", quality=0, sell_in=0)
    app = GildedRose([item])

    app.update_quality()

    assert item.quality == 0


def test_aged_brie_gets_better_with_age():
    item = Item(name="Aged Brie", quality=10, sell_in=10)
    app = GildedRose([item])

    app.update_quality()

    assert item.quality == 11


def test_quality_is_never_over_fifty():
    item = Item(name="Aged Brie", quality=50, sell_in=10)
    app = GildedRose([item])

    app.update_quality()

    assert item.quality == 50


def test_quality_gets_better_faster_after_sell_in():
    item = Item(name="Aged Brie", quality=10, sell_in=0)
    app = GildedRose([item])

    app.update_quality()

    assert item.quality == 12


def test_sulfuras_never_changes():
    item = Item(name="Sulfuras, Hand of Ragnaros", quality=80, sell_in=80)
    app = GildedRose([item])

    app.update_quality()
    app.update_quality()
    app.update_quality()
    app.update_quality()
    app.update_quality()

    assert item.quality == 80
    assert item.sell_in == 80


def test_backstage_passes_quality_props():
    item = Item(name="Backstage passes to a TAFKAL80ETC concert", quality=10, sell_in=11)
    app = GildedRose([item])

    # THIS IS REALLY UGLY AND IT SHOULD BE FIXED
    app.update_quality()
    assert item.quality == 11
    app.update_quality()
    assert item.quality == 13
    app.update_quality()
    app.update_quality()
    app.update_quality()
    app.update_quality()
    assert item.quality == 21
    app.update_quality()
    assert item.quality == 24
    app.update_quality()
    app.update_quality()
    app.update_quality()
    app.update_quality()
    assert item.quality == 36
    app.update_quality()
    assert item.quality == 0
