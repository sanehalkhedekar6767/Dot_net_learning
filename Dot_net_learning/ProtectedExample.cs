using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{


    //Protectes Access Modifier
    //--------->  Base / Parent / Super class
    class Animal   
    {
        //protected member
        protected string Sound;

        //protected method
        protected void MakeSound()
        {
            Console.WriteLine($"Animal makes sound: {Sound}");
        }
    }



    //----------> Derived / Child / Subclass
    class Dog : Animal   //inheritance
    {
        public Dog()
        {
            Sound = "Bark";
        }
        public void DisplaySound()
        {
            MakeSound();
            //Console.WriteLine("test");
        }
    }



    class Cat : Animal
    {
        public Cat() 
        {
            Sound = "Meows";
        }
        public void DisplaySound()
        {
            MakeSound();
        }
        
   }



    class ProtectedExample
    {
        static void Main()
        {


            //Animal a = new Animal();
            Cat c = new Cat();
            c.DisplaySound();


        }
    }
}
