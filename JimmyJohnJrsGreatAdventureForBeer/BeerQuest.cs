namespace JimmyJohnJrsGreatAdventureForBeer;

public class BeerQuest
{
    JimmyJohnJr jimmy = new();
    List<Drinks> shopInventory = new() {};
    DrinksInventory drinksInventory = new();
    EnemyFactory enemyFactory = new();
    string keepBuying = "yes";
    int numberOfItemBought;
    float wantedLevel = 0;
    public void EpicGameMoment()
    {
        enemyFactory.PossibleEnemiesDuringLevels(wantedLevel);
        drinksInventory.FillInvetoriesAtStart(shopInventory);
        Console.WriteLine("You wake up in a bar with nothing except some money. You also happen to be an extreme alchoholic and gamblign addict");
        Console.WriteLine("You remember you changed your name to Jimmy John Jr when you got scammed by some random hobo which is also how you lost all your stuff");
        Console.WriteLine("Since you are an alchoholic becoming sober is your greatest enemy so you realise you have to buy some alchohol to stop it before going on your adventure");
        Console.WriteLine("Then you wonder what adventure that is until you remember that Prips Blå Premium 200% alcohol is on sale for only 1000 money. What type of money it was you dont remember, for all you know it could be dollar or sek or some currency from space but thats isnt gonna stop you");
        Console.ReadLine();
        Console.Clear();
        while(keepBuying == "yes" || keepBuying == "y")
        {
            Console.WriteLine("What will you buy?");
            Console.WriteLine();
            Console.WriteLine($"Your Money: {jimmy.money}");
            Console.WriteLine();
            for(int i = 0; i < shopInventory.Count; i++)
            {
                Console.WriteLine($"{i+1}. Name: {shopInventory[i].name}");
                Console.WriteLine($"Alcohol Persentage: {shopInventory[i].alcoholLevel}");
                Console.WriteLine($"Description: {shopInventory[i].description}");
                Console.WriteLine($"Cost: {shopInventory[i].cost}");
                Console.WriteLine($"Vomit Chance:{shopInventory[i].vomitChance}");
                Console.WriteLine("");
            }
            Console.WriteLine($"Write the number of what you want to buy or any number above {shopInventory.Count} if you don't wish to purchase anything");
            int drinkChoice;
            while(!int.TryParse(Console.ReadLine(), out drinkChoice))
            {
                Console.WriteLine("Did you forgot what a number was? A number is a symbol such as 1, 2 or 3 near the top of your keyboard");
                Console.WriteLine("Try again: ");
            }
            Console.WriteLine("How many do you want to buy?");
            while(!int.TryParse(Console.ReadLine(), out numberOfItemBought))
            {
                Console.WriteLine("Did you forgot what a number was? A number is a symbol such as 1, 2 or 3 near the top of your keyboard");
                Console.WriteLine("Try again: ");
            }
            if(drinkChoice <= shopInventory.Count && jimmy.money - (shopInventory[drinkChoice-1].cost * numberOfItemBought) >= 0)
            {
                jimmy.beerInventory.Add(shopInventory[drinkChoice+1]);
                Console.WriteLine($"You now have {shopInventory[drinkChoice-1].name} in your collection");
                jimmy.money -= shopInventory[drinkChoice-1].cost;
            }
            else if(jimmy.money - (shopInventory[drinkChoice-1].cost * numberOfItemBought) < 0)
            {
                Console.WriteLine("You need more money to fulfill your alcoholist dreams");
                Console.WriteLine($"You can buy up to {(int)(jimmy.money/shopInventory[drinkChoice-1].cost)} {shopInventory[drinkChoice-1].name}");
            }
            else
            {
                Console.WriteLine("Looks like you don't want to buy anything");
            }
            Console.WriteLine("Do you want to buy something else? (y/n)");
            keepBuying = Console.ReadLine().ToLower();
            Console.Clear();
        }
        Console.ReadLine();
        while(jimmy.knockoutMeter >= 1)
        {
            
        }
    }
}
