using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Animalerie
    {
        protected List<Animal> _animals;
        public event Action<Animal> OnAddAnimal;

        public List<Animal> Animals
        {
            get => _animals;
            set => _animals = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Animalerie()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            OnAddAnimal?.Invoke(animal);
            for (int i = 0; i < _animals.Count; i++)
            {
                _animals[i].TryEat(animal);
            }
        }

        public bool Contains(Animal animal)
        {
            return _animals.Contains(animal);
        }

        public Animal GetAnimal(int animalIndex)
        {
            return _animals[animalIndex];
        }

        public void FeedAll()
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                _animals[i].Feed();
            }
        }
    }
}
