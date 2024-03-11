namespace JimmyJohnJrsGreatAdventureForBeer;

public class Police : Enemy
{
    public Police()
    {
        name = "Police Officer";
        knockoutMeterMax = 50;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 10;
        dropAmount = 30;
        sobrietyIncrease = 5;
        wantedLevelIncrease = 7.5f;
    }
}
