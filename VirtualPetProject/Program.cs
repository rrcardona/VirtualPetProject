using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Program
    {
        public static int EatingTime { get; private set; }
        public static int SleepTime { get; private set; }

        static void Main(string[] args)
        {

            Pet Spike = new Pet();
            Console.WriteLine("Hi I'm Spike The Gada. I heard you were taking care of me for a while. Sounds fun!!!! Lets go to it gator");
            do
            {
                Console.WriteLine("Hey gator, what do you wanna do now?\nPress 1 to Hunt \nPress 2 to Eat \nPress 3 to go to the Bathroom \nPress 4 to go to Sleep");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                        Spike.HuntingTime();
                        break;
                    case "2":
                        Spike.EatingTime();
                        break;
                    case "3":
                        Spike.BathroomTime();
                        break;
                    case "4":
                        Spike.SleepTime();
                        break;
                }
            }
            while (SleepTime >= 5 && EatingTime >= 5);          
            {
                Console.WriteLine("Thank you for taking care of me");
            }


            
            
    }
}

 











}
