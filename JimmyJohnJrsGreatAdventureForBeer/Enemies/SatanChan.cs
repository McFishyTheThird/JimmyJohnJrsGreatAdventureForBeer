namespace JimmyJohnJrsGreatAdventureForBeer;

public class SatanChan : Enemy
{
    public SatanChan()
    {
        name = "Satan-Chan";
        knockoutMeterMax = 250;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 40;
        dropAmount = 70;
        sobrietyIncrease = 40;
        wantedLevelIncrease = 50;
    }
}
