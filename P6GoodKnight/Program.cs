// See https://aka.ms/new-console-template for more information

using P6GoodKnight;

var attacker = new Knight();
var defender = new Knight();
defender.shield.Equip();
attacker.Attack(defender);
attacker.sword.Equip();
attacker.Attack(defender);
attacker.Attack(defender);
