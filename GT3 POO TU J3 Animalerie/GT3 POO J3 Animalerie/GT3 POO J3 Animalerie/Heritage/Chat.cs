using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {
        public Chat(string name) : base(name)
        {
            _pattes = 4;
        }

        public override string Crier()
        {
            if (_isFed == false)
                return "Miaou (j'ai faim)";
            else
                return "Miaou (c'est bon laisse moi tranquille humain)";
        }

        public override bool TryEat(Animal animal)
        {
            return animal is Poisson;
        }

        public override void Die()
        {
            base.Die();
        }

        public override void Welcome(Animalerie animalerie)
        {
            List<Animal> animals = animalerie.Animals;
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] is Poisson && _isFed == false)
                {
                    _isFed = true;
                    _ateFish = true;
                    
                    animals.Remove(animals[i]);
                }


            }
        }
    }
}
