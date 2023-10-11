namespace P6GoodKnight;

public class Sword
{
   public bool isEquipped;

   public Sword(bool isEquipped)
   {
      this.isEquipped = isEquipped;
   }

   public void Equip()
   {
      Console.WriteLine("Equipping Sword...");
      isEquipped = true;
   }

   public void Unequip()
   {
      Console.WriteLine("Removing Sword...");
      isEquipped = false;
   }
   public bool IsAttackSuccessfull(Shield defenderShield)
   {
      if (defenderShield.IsBlocking())
      {
         Console.WriteLine("Knights Shield was pierced by the Sword.");
         return false;
      }

      return true;
   }
}