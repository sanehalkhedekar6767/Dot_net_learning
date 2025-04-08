using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    class ConstantEx
    {
        //Normal variable declaration
        public int a = 10;
        public string name = "Kris";

        //Constant variable declaration  ---> declared only class and inside method level
        public const double pi = 3.14;
        const string personName = "Junu";

        public void PrintConstantValues()
        {
            Console.WriteLine($"Pi: {pi} ");
            Console.WriteLine($"PersonName: {personName}");
            name = "New Kris";
            Console.WriteLine(name);
            //personName = "new Junu";  //constant variable not redeclared---->error
        }


    }
    class ConstantExample
    {
            static void Main()
            {
                ConstantEx obj = new ConstantEx();
                obj.PrintConstantValues();
            }
    }
}
