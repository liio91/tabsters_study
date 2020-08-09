using System.Collections.Generic;

namespace Tabsters
{
    public class Shop
    {
        private List<Animal> animals;
        private int cash;

        public Shop(int cash)
        {
            this.animals = new List<Animal>();
            this.cash = cash;
        }

        public int GetCash()
        {
            return this.cash;
        }

        public bool AddAnimal(Animal animal)
        {
            if (animal == null)
                return false;

            if (animal.GetPrice() > cash)
                return false;

            this.animals.Add(animal);
            this.cash = this.cash - animal.GetPrice();
            return true;
        }

        public List<Animal> AddAnimals(List<Animal> animals)
        {
            if (animals == null)
                return null;

            var addedAnimals = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (AddAnimal(animal))
                    addedAnimals.Add(animal);
            }

            return addedAnimals;
        }

        public bool RemoveAnimal(Animal animal)
        {
            if (animal == null)
                return false;
            
            bool removed = this.animals.Remove(animal);

            if (!removed)
                return false;

            this.cash = this.cash + animal.GetPrice();
            return true;
        }

        public List<Animal> RemoveAnimals(List<Animal> animals)
        {
            if (animals == null)
                return null;

            var removedAnimals = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (RemoveAnimal(animal))
                    removedAnimals.Add(animal);
            }

            return removedAnimals;
        }
    }
}