namespace JimmyJohnJrsGreatAdventureForBeer;

public class JusticeSystem : Enemy
{
    public JusticeSystem()
    {
        name = "Justice System";
        knockoutMeterMax = 200;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 25;
        knockoutPowerMax = 20;
        dropAmount = 50;
        sobrietyIncrease = 15;
        wantedLevelIncrease = 25;
    }
}
