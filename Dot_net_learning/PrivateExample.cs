using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    class PrivateClass
    {
        //Private property
        private int PrivateField;

        //Private Method
        private void SetField(int value)
        {
            PrivateField = value;
        }

        //Private  Method
        private void Show()
        {
            Console.WriteLine("Private field value " + PrivateField);
        }
    }

    class PrivateExample
    {
        //Private property
        private int PrivateField;

        //Private Method
        private void SetField(int value)
        {
            PrivateField = value;
        }

        //Private  Method
        private void Show()
        {
            Console.WriteLine("Private field value " + PrivateField);
        }
        static void Main()
        {
            //PrivateClass obj = new PrivateClass();
            PrivateExample obj1 = new PrivateExample();
            obj1.SetField(10);  //private field not accessible
            obj1.PrivateField = 3;

            InternalExample obj2 = new InternalExample();
            obj2.sound = "Roar";//overiden variable/ member
            obj2.MakingSound();

        }
    }
}
