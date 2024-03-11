namespace JimmyJohnJrsGreatAdventureForBeer;

public class NormalPerson : Enemy
{
    public NormalPerson()
    {
        name = "Normal Person";
        knockoutMeterMax = 20;
        knockoutMeter = knockoutMeterMax;
        knockoutPowerMax = 5;
        knockoutPowerMin = 1;
        dropAmount = 10;
        sobrietyIncrease = 1.5f;
        wantedLevelIncrease = 2.5f;
    }
}
