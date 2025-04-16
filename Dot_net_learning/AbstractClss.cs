using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //instance of abstract class cant be created
    public abstract class Animal1
    {
        public int a, b;


        //Abstract Method (no implementation)
        public abstract void MakeSound();


        //Non-abstract method(has implementation)
        public void Eating()
        {
            Console.WriteLine("Animal is eating");
        }
    }


    //Derived class
    public class Lion: Animal1
    {

        public override void MakeSound()
        {
            Console.WriteLine("Lion ROARS !!!");
        }
    }


    //Derived class
    public class Tiger : Animal1 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tiger SOUNDS");
        }
    }

    internal class AbstractClss
    {
        static void Main()
        {
            //cannot create instance of abstract class
            //Animal1 animal = new Animal1();  

            Lion l = new Lion();
            l.MakeSound();
            l.Eating();

            Tiger t = new Tiger();
            t.MakeSound();
            t.Eating();

        }

    }
}
