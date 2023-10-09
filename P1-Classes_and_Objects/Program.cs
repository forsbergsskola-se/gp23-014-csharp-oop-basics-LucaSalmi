// See https://aka.ms/new-console-template for more information


var personOne = new Person();
var personTwo = new Person();
var personThree = new Person();
Person[] listOfPeople = {personOne, personTwo, personThree};
foreach (var person in listOfPeople)
{
    Print(person);
}
void Print(Object toPrint)
{
    Console.WriteLine(toPrint);
}


public class Person
{
    //LOL
}