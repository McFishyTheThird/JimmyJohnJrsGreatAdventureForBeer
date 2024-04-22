namespace JimmyJohnJrsGreatAdventureForBeer;

public class Characters
{
    public int knockoutMeter{get; set;}
    public int knockoutMeterMax{get; set;}
    public float knockoutPowerMax{get; set;}
    public float knockoutPowerMin{get; set;}
    public float attackValue;
    public virtual float AttackValue()
    {
        return Random.Shared.Next((int)knockoutPowerMin,(int)knockoutPowerMax);
    }
    public void Attack(Characters opponent, Enemy enemy)
    {
        attackValue = AttackValue();
        opponent.knockoutMeter -= (int)attackValue;
        if(opponent.knockoutMeter < 0)
        {
            opponent.knockoutMeter = 0;
        }
        if(opponent == enemy)
        {
            Console.WriteLine($"You deal {attackValue} damage to the {enemy.name}");
            Console.WriteLine($"{enemy.name}s Current Life:{opponent.knockoutMeter}/{opponent.knockoutMeterMax}");
        }
        else
        {
            Console.WriteLine($"You take {attackValue} damage");
        }
    }
}
