namespace JimmyJohnJrsGreatAdventureForBeer;

public class DrinksInventory
{
    Beer beer = new();
    Guinness guinness = new();
    Martini martini = new();
    Vodka vodka = new();
    Whiskey whiskey = new();
    HandSanitizer handSanitizer = new();
    PremiumHandSanitizer premiumHandSanitizer = new();
    PureAlcohol pureAlcohol = new();
    AuntRoberta auntRoberta = new();
    public void FillInvetoriesAtStart(List<Drinks> shopInventory)
    {
        shopInventory.AddRange(new List<Drinks>{beer, guinness, martini, vodka, whiskey, handSanitizer, premiumHandSanitizer, pureAlcohol, auntRoberta});
    }
}
