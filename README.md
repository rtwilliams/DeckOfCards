# DeckOfCards
Incorporates use of Polymorphism or Strategy Pattern

The goal with the DeckOfCards application was to provide a design that can deal, shuffle, draw and reset different decks of cards, such as a standard deck or an Uno deck. The standard deck deals five cards per deal, whereas the Uno deck deals 11 cards per deal. 

To implement this behavior, the use of Polymorphism and Inheritance was applied... or some may call it the Strategy Pattern. This is done by using interfaces for method argument types, such as Shuffle(ICardGame game). Such a design loosely couples the card game from the console menu operations. 
