namespace P6GoodKnight;

public class Knight
{
    public Shield shield = new Shield(false);
    public Sword sword = new Sword(false);
    private bool isWounded = false;

    private void GetHit(Sword weapon)
    {
        if (weapon.isEquipped)
        {
            if (weapon.IsAttackSuccessfull(shield))
            {
                GetWounded();
                return;
            }

            shield.isEquipped = false;
        }
    }

    private void GetWounded()
    {
        isWounded = true;
        Console.WriteLine("The knight has no shield and is wounded.");
    }

    public void Attack(Knight target)
    {
        if (!sword.isEquipped)
        {
            Console.WriteLine("Knight attacks with Bare Hands.");
            if (!target.shield.IsBlocking())
            {
                target.GetWounded();
            }

            return;
        }

        Console.WriteLine("Knight attacks Knight with a Sword.");
        target.GetHit(sword);
    }
}