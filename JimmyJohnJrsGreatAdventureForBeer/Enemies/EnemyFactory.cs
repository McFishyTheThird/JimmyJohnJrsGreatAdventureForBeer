namespace JimmyJohnJrsGreatAdventureForBeer;

public class EnemyFactory
{
    NormalPerson normalPerson = new();
    Police police = new();
    JusticeSystem justiceSystem = new();
    AlchoholFreeDrinks alchoholFreeDrinks = new();
    SatanChan satanChan = new();
    EvilMusk evilMusk = new();
    DonaldTrump donaldTrump = new();
    HydrogenBomb hydrogenBomb = new();
    HospitalBill hospitalBill = new();
    int enemyLevel = 0;
    public List<Enemy> enemies = new();

    public void PossibleEnemiesDuringLevels(float wantedLevel)
    {
        if (wantedLevel == 0 && enemyLevel == 0)
        {
            enemies.Add(normalPerson);
            enemyLevel++;
        }
        if (wantedLevel >= 10 && enemyLevel == 1)
        {
            enemies.AddRange(new List<Enemy>{police, police});
            enemyLevel++;
        }
        if(wantedLevel >= 40 && enemyLevel == 2)
        {
            wantedLevel = 40;
            enemies.Clear();
            enemies.Add(justiceSystem);
            enemyLevel++;
        }
        if(wantedLevel >= 65 && enemyLevel == 3)
        {
            enemies.Clear();
            enemies.AddRange(new List<Enemy>{alchoholFreeDrinks, alchoholFreeDrinks, alchoholFreeDrinks, satanChan});
            enemyLevel++;
        }
        if(wantedLevel >= 215 && enemyLevel == 4)
        {
            wantedLevel = 215;
            enemies.Clear();
            enemies.AddRange(new List<Enemy>{alchoholFreeDrinks, evilMusk, evilMusk});
            enemyLevel++;
        }
        if(wantedLevel >= 315 && enemyLevel == 5)
        {
            wantedLevel = 315;
            enemies.Clear();
            enemies.Add(donaldTrump);
            enemyLevel++;
        }
        if(wantedLevel >= 1315 && enemyLevel == 6)
        {
            enemies.Remove(donaldTrump);
            enemies.Add(hydrogenBomb);
            enemyLevel++;
        }
        if(wantedLevel >= 1316 && enemyLevel == 7)
        {
            enemies.Remove(hydrogenBomb);
            enemies.Add(hospitalBill);
            enemyLevel++;
        }

    }

    public virtual Enemy GetEnemy()
    {
        return enemies[Random.Shared.Next(enemies.Count)];
    }
}
