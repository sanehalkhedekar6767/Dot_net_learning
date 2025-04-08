using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    public class PublicExampleTest
    {
        //Define Property
        public int pubicProperty { get; set; }

        //Method   
        //[access_modifier] [return_type] [method_name](){}
        public void Display()
        {
            Console.WriteLine("Public property value: " + pubicProperty);
        }
        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }
        public class PublicExample
    {
        static void Main()
        {
                PublicExampleTest obj = new PublicExampleTest();
                obj.pubicProperty = 1;
                obj.Display();
                obj.Show();
        }
    }
}
