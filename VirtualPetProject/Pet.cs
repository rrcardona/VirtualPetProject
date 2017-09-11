using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Pet
    {
        
        //spike the alligator

        private string name;
        private int staminaTime;
        private int huntingTime;
        private int eatingTime;
        private int bathroomTime;
        private int sleepTime;
        private int maxPower;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Stamina
        {
            get { return this.staminaTime; }
            
        }
        public int Survival
        {
            get { return this.huntingTime; }
            
        }
        public int Eating
        {
            get { return this.eatingTime; }
            
        }
        public int Waste
        {
            get { return this.bathroomTime; }
        }
           
        public int Sleep
        {
            get { return this.sleepTime; }
            
        }
        public int MaxPower
        {
            get { return this.maxPower; }
        }
        public Pet()
        {
            this.name = "Spike";
            this.staminaTime = 5;
            this.huntingTime = 5;
            this.eatingTime = 0;
            this.sleepTime = 0;
            this.bathroomTime = 0;
            this.maxPower = 5;                           
        }
        public Pet(string name)
        {
            this.name = name;
        }
        public Pet(string name, int eatingTime, int staminaTime, int huntingTime, int sleepTime, int bathroomTime)
        {
            this.name = name;
            this.eatingTime = eatingTime;
            this.staminaTime = staminaTime;
            this.huntingTime = huntingTime;
            this.sleepTime = sleepTime;
            this.bathroomTime = bathroomTime;
        }
        public void Greeting()
        {
            Console.WriteLine("Hi, my name is Spike!");
        }
        public void PlayingTime ()
        {
            if(this.staminaTime<5)
            {
                Console.WriteLine("I'm tired. I need some rest");
            } 
            else
            {
                this.eatingTime += 1;
                this.sleepTime += 1;
                Console.WriteLine("That was fun!!! My current Stamina to play is {0}",this.staminaTime);
            }
        }
        public void HuntingTime()
        {
            if (this.staminaTime <2)
            {
                Console.WriteLine("I'm too tired for a hunt. I need some sleep!");
            }
            else
            {
                this.bathroomTime = 1;
                this.eatingTime = 2;
                Console.WriteLine("That was fun. I can't wait to see whats on the menu!!!");
            }
        }
        public void EatingTime()
        {
            if (eatingTime <4)
            {
                Console.WriteLine("I'm full!!!");
            }
            else
            {
                this.bathroomTime += 2;
                this.sleepTime += 1;
                Console.WriteLine("Whats on the menu? I'm ready for a feast!");
            }            
        }
        public void BathroomTime()
        {
            if (bathroomTime < 5)
            {
                Console.WriteLine("I'm fine. Let's go do something fun");
            }
            else
            {
                this.eatingTime = 1;
                this.staminaTime = 2;
                Console.WriteLine("A little privacy please");
            }
        }
        public void SleepTime()
        {
            Console.WriteLine("That was a great nap!!! I feel amazing");
            this.staminaTime = maxPower;
            this.huntingTime = maxPower;
                    
        }
    }
}
