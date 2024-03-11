namespace JimmyJohnJrsGreatAdventureForBeer;

public class AlchoholFreeDrinks : Enemy
{
    public AlchoholFreeDrinks()
    {
        name = "0% Drinks";
        knockoutMeterMax = 50;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 20;
        dropAmount = 35;
        sobrietyIncrease = 10f;
        wantedLevelIncrease = 5f;
    }
}
