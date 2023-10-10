class Player
{
    public int damage;

    public void Attack(Player target)
    {
        target.damage += 1;
    }
}