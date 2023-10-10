// See https://aka.ms/new-console-template for more information

// PLayer 3 and player 1 refers to the same object so everything that changes in one changes in the other too
var player1 = new Player();
var player2 = new Player();
player1.Attack(player2);
PrintDamage(player1, player2);
player2.Attack(player1);
PrintDamage(player1, player2);
player1.Attack(player1);
PrintDamage(player1, player2);
var player3 = player1;
player2.Attack(player3);
PrintDamage(player1, player2);
Console.WriteLine($"Player 3 has {player3.damage} damage");



void PrintDamage(Player firstPlayer, Player secondPlayer)
{
    Console.WriteLine($"Player 1 has {firstPlayer.damage} damage");
    Console.WriteLine($"Player 2 has {secondPlayer.damage} damage");
    Console.WriteLine();
}
