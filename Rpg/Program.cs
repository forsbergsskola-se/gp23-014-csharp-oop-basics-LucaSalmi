// See https://aka.ms/new-console-template for more information

using Rpg;

var player = new Player(3);
var monster = new Monster(3);
Console.WriteLine($"""
                   You have {player.hp} Health.
                   You are fighting a monster with {monster.hp} Health
                   """);
while (player.hp > 0)
{
    var userInput = GetUserInput();
    switch (userInput)
    {
        case 'A':
            player.Attack(monster);
            break;
        case 'H':
            player.Heal();
            break;
        default:
            continue;
    }

    // Monster's Turn
    if (monster.hp < 0)
    {
        monster.Attack(player);
    }
    else
    {
        monster = new Monster(3);
        Console.WriteLine($"A new monster spawns with {monster.hp} health");
    }
}

Console.WriteLine("Game Over");
return;

char GetUserInput()
{
    Console.WriteLine("What do you want to do? [A]ttack or [H]eal");
    var key = Console.ReadKey();
    Console.WriteLine();
    return char.ToUpper(key.KeyChar);
}