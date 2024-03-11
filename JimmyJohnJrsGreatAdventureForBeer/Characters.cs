namespace JimmyJohnJrsGreatAdventureForBeer;

public class Characters
{
    public int knockoutMeter{get; set;}
    public int knockoutMeterMax{get; set;}
    public int knockoutPowerMax{get; set;}
    public int knockoutPowerMin{get; set;}
    public virtual int AttackValue()
    {
        return Random.Shared.Next(knockoutPowerMin,knockoutPowerMax);
    }
}
