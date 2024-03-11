namespace JimmyJohnJrsGreatAdventureForBeer;

public class AlchoholFreeDrinks : Enemy
{
    public AlchoholFreeDrinks()
    {
        name = "0% Drinks";
        knockoutMeterMax = 50;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 20;
        knockoutPowerMin = 10;
        dropAmount = 35;
        sobrietyIncrease = 10f;
        wantedLevelIncrease = 5f;
    }
}
