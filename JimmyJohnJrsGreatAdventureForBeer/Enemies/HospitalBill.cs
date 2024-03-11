namespace JimmyJohnJrsGreatAdventureForBeer;

public class HospitalBill : Enemy
{
    public HospitalBill()
    {
        name = "Hospital Bill";
        knockoutMeterMax = 1200;
        knockoutMeter = knockoutMeterMax;
        knockoutPower = 200;
        dropAmount = 0;
        sobrietyIncrease = 99;
        wantedLevelIncrease = 0;
    }
}
