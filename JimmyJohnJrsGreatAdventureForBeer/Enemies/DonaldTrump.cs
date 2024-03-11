namespace JimmyJohnJrsGreatAdventureForBeer;

public class DonaldTrump : Enemy
{
    public DonaldTrump()
    {
        name = "Donald Trump";
        knockoutMeterMax = 500;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 70;
        knockoutPowerMin = 50;
        dropAmount = 0;
        sobrietyIncrease = 30;
        wantedLevelIncrease = 1000;
    }
}
