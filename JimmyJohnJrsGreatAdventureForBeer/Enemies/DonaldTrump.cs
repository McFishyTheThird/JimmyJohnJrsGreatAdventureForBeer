namespace JimmyJohnJrsGreatAdventureForBeer;

public class DonaldTrump : Enemy
{
    public DonaldTrump()
    {
        name = "Donald Trump";
        knockoutMeterMax = 500;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 70;
        dropAmount = 0;
        sobrietyIncrease = 30;
        wantedLevelIncrease = 1000;
    }
}
