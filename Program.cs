using System;
using Inheritance;
using Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Console.WriteLine("Inheritance and Method Overriding ");

        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow

        Console.WriteLine();

        // Abstract Classes and Methods
        Console.WriteLine(" Abstract Classes and Methods ");

        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
    }
}
