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
    public void Attack(Characters opponent)
    {
        opponent.knockoutMeter -= AttackValue();
        if(opponent.knockoutMeter > 0)
        {
            opponent.knockoutMeter = 0;
        }
        Console.WriteLine($"Opponets Current Life:{opponent.knockoutMeter}/{opponent.knockoutMeterMax}");
    }
}
