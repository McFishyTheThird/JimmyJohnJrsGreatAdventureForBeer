namespace JimmyJohnJrsGreatAdventureForBeer;

public class JimmyJohnJr : Characters
{
    public float money;
    public List<Drinks> beerInventory = new();
    public float drunkenMeter;
    public float drunkenLevel;
    public float sobrietyMultiplier;
    public float knockoutPowerMaxOriginal;
    public float knockoutPowerMinOriginal;

    public JimmyJohnJr()
    {
        money = 25; 
        drunkenMeter = 100;
        drunkenLevel = 20;
        knockoutMeter = 100;
        knockoutMeterMax = 100;
        knockoutPowerMax = 10;
        knockoutPowerMaxOriginal = 10;
        knockoutPowerMin = 5;
        knockoutPowerMinOriginal = 5;
    }
    public void Drinking()
    {
        
    }
}
