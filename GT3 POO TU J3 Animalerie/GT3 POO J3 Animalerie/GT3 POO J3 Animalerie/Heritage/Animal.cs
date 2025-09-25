using System.Diagnostics.CodeAnalysis;

namespace TU_Challenge.Heritage
{

    public class Animal
    {
        protected string _name;
        protected int _pattes;
        protected bool _isFed;
        protected bool _isAlive;
        protected bool _ateFish;
        public event Action OnDie;

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Pattes
        {
            get => _pattes;
            set => _pattes = value;
        }

        public bool IsAlive
        {
            get => _isAlive;
            set => _isAlive = value;
        }

        public Animal(string name)
        {
            _name = name;
            _isFed = false;
            _isAlive = true;
            _ateFish = false;
            _pattes = 0;
        }

        public virtual bool TryEat(Animal animal)
        {
            return false;
        }

        public virtual void Welcome(Animalerie animalerie)
        {
            

        }

        public virtual string Crier()
        {
            return "aa";
        }

        public void Feed()
        {
            _isFed = true;
        }

        public virtual void Die()
        {
            IsAlive = false;
            OnDie?.Invoke();
        }

    }
}
