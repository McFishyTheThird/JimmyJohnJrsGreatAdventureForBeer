namespace JimmyJohnJrsGreatAdventureForBeer;

public class Police : Enemy
{
    public Police()
    {
        name = "Police Officer";
        knockoutMeterMax = 50;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 10;
        knockoutPowerMin = 5;
        dropAmount = 30;
        sobrietyIncrease = 5;
        wantedLevelIncrease = 7.5f;
    }
}
