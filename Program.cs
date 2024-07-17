using MultilevelInheritence.Models;

namespace MultilevelInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            WarmBlooded warmBlooded = new WarmBlooded();
            Mammals mammal = new Mammals();
            Dog dog = new Dog();

            Console.WriteLine($"Dog inherited from Animal Class: {dog.AnimalNoise()}\n" +
                $"Dog inherited from Warmblooded class, which inherited from animal class: {dog.WarmNoises()}\n" +
                $"Dog inherited from Mammals class, which inherited from warm-blooded class: {dog.MammalNoise()}\n" +
                $"Dog: {dog.DogNoise()} ");


        }
    }
}
