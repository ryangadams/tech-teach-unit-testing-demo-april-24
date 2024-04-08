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