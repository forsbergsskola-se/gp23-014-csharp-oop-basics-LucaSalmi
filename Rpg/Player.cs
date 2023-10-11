namespace Rpg;

public class Player
{
    public int hp;
    
    private int attackPower = 1;

    public Player(int hp)
    {
        this.hp = hp;
    }

    public void Attack(Monster target)
    {
        target.hp--;
        Console.WriteLine($"You attack the monster, it has {target.hp} health");
    }

    public void Heal()
    {
        this.hp = 3;
        Console.WriteLine($"You healed fully, you now have {this.hp} health");
    }
}