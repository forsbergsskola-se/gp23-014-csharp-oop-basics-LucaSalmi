// See https://aka.ms/new-console-template for more information





Person person = new Person();
Animal animal = new Animal();
Car car = new Car();

Print(person);
Print(animal);
Print(car);

void Print(Object toPrint)
{
    Console.WriteLine(toPrint);
}

public class Person{}
public class Animal{}
public class Car{}

