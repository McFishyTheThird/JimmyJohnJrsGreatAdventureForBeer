namespace JimmyJohnJrsGreatAdventureForBeer;

public class EvilMusk : Enemy
{
    public EvilMusk()
    {
        name = "Evil Musk Clone";
        knockoutMeterMax = 150;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 50;
        dropAmount = 100;
        sobrietyIncrease = 20;
        wantedLevelIncrease = 20;
    }
}
