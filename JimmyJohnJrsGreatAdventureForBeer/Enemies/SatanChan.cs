namespace JimmyJohnJrsGreatAdventureForBeer;

public class SatanChan : Enemy
{
    public SatanChan()
    {
        name = "Satan-Chan";
        knockoutMeterMax = 250;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 40;
        knockoutPowerMin = 20;
        dropAmount = 70;
        sobrietyIncrease = 40;
        wantedLevelIncrease = 50;
    }
}
