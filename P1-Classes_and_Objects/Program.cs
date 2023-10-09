// See https://aka.ms/new-console-template for more information
Print(CreateListOfPeople(5));
return;

void Print(Person[] listToPrint)
{
    foreach (var person in listToPrint)
    {
        Console.WriteLine(person);
    }
}

Person[] CreateListOfPeople(int amount)
{
    var list = new Person[amount];
    for (var i = 0; i < amount; i++)
    {
        list[i] = new Person();
    }

    return list;
}