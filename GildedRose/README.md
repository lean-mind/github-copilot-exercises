# Gilded Rose

Inventory system for a store that buys and sells high-quality products.
In this system, items decrease in quality (Quality) as their sale date approaches, and
this depreciation is updated automatically.

This inventory system was developed by a person who is no longer available to make
new implementations.

Below, we will explain how the current system works so you can quickly integrate

## General Rules

### Rule 1: Degradation of `Quality` and `SellIn`

- **Given** an `item` with initial values of `SellIn` and `Quality`
- **When** a day passes
- **Then** the value of `SellIn` decreases by 1
- **And** the value of `Quality` decreases by 1

### Rule 2: Degradation of `Quality` after the sell-by date

- **Given** an `item` with `SellIn` less than 0
- **When** a day passes
- **Then** the value of `Quality` decreases by 2

### Rule 3: `Quality` is never negative

- **Given** an `item` with `Quality` equal to 0
- **When** a day passes
- **Then** the value of `Quality` remains 0

### Rule 4: `Quality` is never more than 50

- **Given** an `item` with `Quality` equal to 50
- **When** a day passes
- **Then** the value of `Quality` remains 50

## Special Cases

### Special Case 1: `Aged Brie`

- **Given** an `item` named "Aged Brie"
- **When** a day passes
- **Then** the value of `Quality` increases by 1
- **And** if `SellIn` is less than 0, the value of `Quality` increases by 2

### Special Case 2: `Sulfuras, Hand of Ragnaros`

- **Given** an `item` named "Sulfuras, Hand of Ragnaros"
- **When** a day passes
- **Then** the value of `SellIn` and `Quality` remain unchanged
- **And** the value of `Quality` is always 80

### Special Case 3: `Backstage passes to a TAFKAL80ETC concert`

- **Given** an `item` named "Backstage passes to a TAFKAL80ETC concert"
- **When** `SellIn` is greater than 10
- **Then** the value of `Quality` increases by 1
- **When** `SellIn` is 10 or less
- **Then** the value of `Quality` increases by 2
- **When** `SellIn` is 5 or less
- **Then** the value of `Quality` increases by 3
- **When** `SellIn` is less than 0
- **Then** the value of `Quality` is 0