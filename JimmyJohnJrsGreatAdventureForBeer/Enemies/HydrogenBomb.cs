namespace JimmyJohnJrsGreatAdventureForBeer;

public class HydrogenBomb : Enemy
{
    public HydrogenBomb()
    {
        name = "Hydrogen bomb";
        knockoutMeterMax = 100000;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 0;
        knockoutPowerMin = 0;
        dropAmount = 0;
        sobrietyIncrease = 0;
        wantedLevelIncrease = 1;
    }
}
