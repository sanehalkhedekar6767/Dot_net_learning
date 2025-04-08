using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{

//Protected Access Modifier
//Parent class
    class Person2
    {
        protected int employeeId;
        protected string employeeName;
        protected string address;

        protected void Details()
        {
            Console.WriteLine($"Person Details --> Id: {employeeId}, Name: {employeeName}, Address: {address}");
        }
    }
    //Child Class
     class Employee : Person2
    {
        public  Employee()
        {
            employeeId = 101;
            employeeName = "Sanehal Khedekar";
            address = "Pune";
        }
        public void DisplayDetails()
        {
            Details();
        }
       
    }

 //Private Access Modifier
 class Person3
    {

    }


    class AssignAccessModifier2
    {

        private string firstName;
        private string lastName;

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }
        static void Main(string[] args)
        {
            //Protected Access Modifier
            //Employee e = new Employee();
            //e.DisplayDetails();

            //Private Access Modifier
            AssignAccessModifier2 p = new AssignAccessModifier2();
            p.firstName = "Sanehal";
            p.lastName = "Khedekar";
            p.DisplayFullName();
        }
        

    }


}
