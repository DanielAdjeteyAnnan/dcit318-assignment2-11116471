using System;
using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Inheritance and Method Overriding ");

        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow
    }
}
