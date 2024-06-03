using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        abstract public void DoSound();

        virtual public string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

    class Horse : Animal
    {
        public string Breed { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Breed: {Breed}";
        }

        public Horse(string name, int age, double weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs");
        }
    }

    class Dog : Animal
    { 
        public string furColor { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Fur color: {furColor}";
        }

        public void Barkbark()
        {
            Console.WriteLine("Bark bark bark");
        }
        public Dog(string name, int age, double weight, string furColor) : base(name, age, weight)
        {
            this.furColor = furColor;
        }

        public override void DoSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    class Hedgehog : Animal
    { 
        public int NrOfSpikes { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Number of spikes: {NrOfSpikes}";
        }
        public Hedgehog(string name, int age, double weight, int nrOfSpikes) : base(name, age, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("The hedgehog snuffles");
        }
    }

    class Worm : Animal
    { 
        public bool IsPoisonous { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is poisonous: {IsPoisonous}";
        }
        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("The worm wriggles");
        }
    }

    class Bird : Animal
    { 
        public double WingSpan { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Wing span: {WingSpan}";
        }

        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("The bird chirps");
        }
    }

    class Wolf : Animal
    { 
        public int NrOfTeeth { get; set; }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Number of teeth: {NrOfTeeth}";
        }

        public Wolf(string name, int age, double weight, int nrOfTeeth) : base(name, age, weight)
        {
            NrOfTeeth = nrOfTeeth;
        }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls");
        }
    }

    class Flamingo : Bird
    {
        public double NeckLength { get; set; }

        public Flamingo(string name, int age, double weight, double wingSpan, double neckLength) : base(name, age, weight, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override void DoSound()
        {
            Console.WriteLine("The flamingo squawks");
        }
    }

    class Pelican : Bird
    {
        public double BeakLength { get; set; }

        public Pelican(string name, int age, double weight, double wingSpan, double beakLength) : base(name, age, weight, wingSpan)
        {
            BeakLength = beakLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("The pelican squawks");
        }
    }

    class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, int age, double weight, double wingSpan, double neckLength) : base(name, age, weight, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override void DoSound()
        {
            Console.WriteLine("The swan honks");
        }
    }


}
