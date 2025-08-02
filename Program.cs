using System;
using Inheritance;
using Abstraction;
using Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Inheritance
        Console.WriteLine(" Inheritance and Method Overriding ");
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();
        genericAnimal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.WriteLine();

        // Abstraction
        Console.WriteLine(" Abstract Classes and Methods ");
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

        Console.WriteLine();

        // Interfaces
        Console.WriteLine(" Interfaces ");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();
        car.Move();
        bicycle.Move();
    }
}
