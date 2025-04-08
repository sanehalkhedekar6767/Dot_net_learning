using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    public class CopyConstructorEx
    {
        //Paramemter declaration
        public string Name {  get; set; }
        public int Age { get; set; }
        public string NameNew {  get; set; }
        public int AgeNew {  get; set; }


        //parameter constructor
        public CopyConstructorEx(String name,int age)
        {
            Name = name;
            Age = age;
        }


        //Copy constructor
        public CopyConstructorEx(CopyConstructorEx copyex)
        {
            NameNew = copyex.Name;
            AgeNew = copyex.Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public void DisplayInfoNew()
        {
            Console.WriteLine($"Namenewp: {NameNew}, Agenew: {AgeNew}");
        }
    }
    class CopyConstructorExample
    {
        static void Main()
        {
            //Creating object with pass the value for parameterized constructor
            CopyConstructorEx objPara = new CopyConstructorEx("Junu", 25);
            objPara.DisplayInfo();

            //Creating object using copy constructor
            CopyConstructorEx objcopy = new CopyConstructorEx(objPara);
            objcopy.DisplayInfoNew();

        }
    }
}
