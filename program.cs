using System;
using System.Collections.Generic;

namespace Tabsters
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop(5000);

            var dog = new Dog();
            var dog2 = new Dog();
            var cat = new Cat();
            var cat2 = new Cat();

            shop.AddAnimal(dog);

            System.Console.WriteLine(shop.GetCash());
            System.Console.WriteLine(shop.RemoveAnimal(cat));

            shop.AddAnimals(new List<Animal>{dog2, cat, cat2});

            System.Console.WriteLine(shop.GetCash());
            System.Console.WriteLine(shop.RemoveAnimal(cat));
            System.Console.WriteLine(shop.GetCash());

            shop.RemoveAnimals(new List<Animal>{dog, dog2, cat2, cat});
            System.Console.WriteLine(shop.GetCash());
        }
    }
}