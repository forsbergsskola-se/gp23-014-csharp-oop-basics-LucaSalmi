namespace Rpg;

public class Monster
{
    public int hp;

    public Monster(int hp)
    {
        this.hp = hp;
    }

    private int attackPower = 1;

    public void Attack(Player target)
    {
        target.hp--;
        Console.WriteLine($"The monster attacks you, you have {target.hp} health");
    }
}