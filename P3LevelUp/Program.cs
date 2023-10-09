// See https://aka.ms/new-console-template for more information
Main();
void Main()
{
    var myPlayer = new Player();
    Console.WriteLine("How much XP do you want to gain?");
    do
    {
        if (!int.TryParse(Console.ReadLine(), out var amount))
        {
            Console.WriteLine("Invalid Input, only whole numbers are accepted");
            continue;
        }
        
        myPlayer.GrantExperience(amount);
        Console.WriteLine($"The Player is level {myPlayer.level} and has {myPlayer.experience} xp");

    } while (true);
}