namespace P6GoodKnight;

public class Shield
{
    public bool isEquipped;

    public Shield(bool isEquipped)
    {
        this.isEquipped = isEquipped;
    }

    public void Equip()
    {
        Console.WriteLine("Equipping Shield...");
        isEquipped = true;
    }

    public void Unequip()
    {
        Console.WriteLine("Removing Shield...");
        isEquipped = false;
    }

    public bool IsBlocking()
    {
        if (isEquipped)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
        }
        return isEquipped;
    }
}