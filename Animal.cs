﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning_3
{
    internal abstract class Animal
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        protected Animal()
        {
        }

        protected Animal(string name, int age, double weight) : this()
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public abstract string DoSound();
        public virtual string Stats() { return $"{GetType().Name} {Name} is {Age} years old, weighs {Weight} kg"; }
    }

    class Horse : Animal
    {
        private int stallNumber;

        public int StallNumber
        {
            get { return stallNumber; }
            set { stallNumber = value; }
        }

        public Horse(string name, int age, double weight, int stallNumber)
        {
            Name = name;
            Age = age;
            Weight = weight;
            StallNumber = stallNumber;
        }

        public Horse()
        {
        }

        public override string DoSound()
        {
            return "Ihhhihihihihiii!";
        }

        public override string Stats() { return $"{base.Stats()} and sleeps in stall number {StallNumber}."; }
    }

    class Dog : Animal
    {
        private bool bites;

        public Dog(string name, int age, double weight, bool bites)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Bites = bites;
        }

        public bool Bites
        {
            get { return bites; }
            set { bites = value; }
        }

        public override string DoSound()
        {
            return "Ham, ham!";
        }

        public override string Stats() { return $"{base.Stats()} and it is {Bites} that it bites."; }

        public string Drink() { return $"{GetType().Name} {Name} is drinking water."; }
    }

    class Hedgehog : Animal
    {
        private int nrOfSpikes;

        public int NrOfSpikes
        {
            get { return nrOfSpikes; }
            set { nrOfSpikes = value; }
        }

        public override string DoSound()
        {
            return "Sniff, sniff!";
        }
        public override string Stats() { return $"{base.Stats()} and has {NrOfSpikes} spikes."; }
    }

    class Worm : Animal
    {
        private bool isPoisonous;

        public bool IsPoisonous
        {
            get { return isPoisonous; }
            set { isPoisonous = value; }
        }

        public override string DoSound()
        {
            return "...";
        }
        public override string Stats() { return $"{base.Stats()} and it is {IsPoisonous} that is poisonous."; }
    }

    class Bird : Animal
    {
        private double wingspan;

        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }

        public override string DoSound()
        {
            return "Piu, piu!";
        }

        public override string Stats() { return $"{base.Stats()} and has a wingspan of {Wingspan} cm"; }
    }

    class Wolf : Animal
    {
        public bool HasSheepFur { get; set; } = true;

        public override string DoSound()
        {
            return "Auuuuu!";
        }

        public override string Stats() { return $"{base.Stats()} and it is {HasSheepFur} that it has a sheep fur."; }
    }

    class Pelican : Bird
    {
        public string DeltaOfResidence
        { get; set; } = "Danube";

        public override string Stats() { return $"{base.Stats()} and it resides in {DeltaOfResidence} Delta."; }
    }

    class Flamingo : Bird
    {
        private double legLength;

        public double LegLength
        {
            get { return legLength; }
            set { legLength = value; }
        }

        public override string Stats() { return $"{base.Stats()} and its legs are {LegLength} cm long."; }
    }

    class Swan : Bird
    {
        private double neckLength;

        public double NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }

        public override string Stats() { return $"{base.Stats()} and its neck is {NeckLength} cm long."; }
    }

    interface IPerson
    {
        void Talk();
    }

    class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I am shy, but if I catch you, I eat you!");
        }
    }
    /*13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
             attribut, i vilken klass bör vi lägga det?
          S: I Bird.
      14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
          S: I Animal. */
}