using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{

    //Base class
    class Person1
    {
        public string name { get; set; }
        public int age { get; set; }
        public void Show()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }

    class Student: Person1
    {
        public void Study()
        {
            Console.WriteLine($"{name} is studying");
        }
       
    }


    class Teacher: Person1
    {
        public string teacherName { get; set; }
        public void Teaches()
        {
            Console.WriteLine($"{teacherName} is Teaching");
        }

    }

    class Principal: Teacher
    {
        public void prince()
        {
            Console.WriteLine($"Principal calls {teacherName} ");
        }
    }

    internal class AssignInheritance
    {
        static void Main()
        {
            Student s = new Student();
            s.name = "Junu";
            s.age = 20;
            s.Show();
            s.Study();

            Teacher t = new Teacher();
            t.teacherName = "Kris Gates";
            t.name = "Junu";
            t.age = 20;
            t.Show();
            t.Teaches();


            Principal p = new Principal();
            p.teacherName = "Kris Gates";
            p.name = "Junu";
            p.age = 20;
            p.prince();
            p.Show();
            p.Teaches();


        }
    }
}
