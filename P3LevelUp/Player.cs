public class Player
{
    public void GrantExperience(int gainedXP)
    {
        experience += gainedXP;
        do
        {
            if (experience < 100) continue;
            LevelUp();
            experience -= 100;
        } while (experience > 100);
    }

    void LevelUp()
    {
        level++;
    }

    public int level { get; set; }
    public int experience { get; set; }
}