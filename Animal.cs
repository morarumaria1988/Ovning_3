using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    internal abstract class Animal
    {
        private string name;
        private int age;
        private int weight;

        protected Animal()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get => age; set => age = value; }
        public int Weight { get => weight; set => weight = value; }
        public abstract void DoSound();
    }

    class Horse : Animal
    {
        private int stallNumber;

        public int StallNumber
        {
            get { return stallNumber; }
            set { stallNumber = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Ihhhihihihihiii!");
        }
    }

    class Dog : Animal
    {
        private Boolean bites;

        public Boolean Bites
        {
            get { return bites; }
            set { bites = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Ham, ham!");
        }
    }

    class Hedgehog : Animal
    {
        private int nrOfSpikes;

        public int NrOfSpikes
        {
            get { return nrOfSpikes; }
            set { nrOfSpikes = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Sniff, sniff!");
        }
    }

    class Worm : Animal
    {
        private int nrOfDays;

        public int NrOfDays
        {
            get { return nrOfDays; }
            set { nrOfDays = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("...");
        }
    }

    class Bird : Animal
    {
        private double WingSpan;

        public double wingSpan
        {
            get { return WingSpan; }
            set { WingSpan = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Piu, piu!");
        }
    }

    class Wolf : Animal
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Auuuuu!");
        }
    }

    class Pelican : Bird
    {
        private string deltaOfResidence;

        public string DeltaOfResidence
        { get; set; } = "Danube";

    }

    class Flamingo : Bird
    {
        private double legLength;

        public double LegLength
        {
            get { return legLength; }
            set { legLength = value; }
        }

    }

    class Swan : Bird
    {
        private double neckLength;

        public double NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }
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
