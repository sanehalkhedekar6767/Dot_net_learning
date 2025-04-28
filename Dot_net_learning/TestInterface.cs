using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal interface ITestInterface1
    {
        void MakePayment(decimal Amount);
        void refundPayment(decimal amount);
    }


    internal interface ITestInterface2
    {
        void MakeUPIPayment(decimal Amount);
    }


    public  class CreditCardPayment : ITestInterface1, ITestInterface2
    {
        public void MakePayment(decimal Amount)
        {
            Console.WriteLine($"Credit card payment of {Amount} has been made");
        }

        public void refundPayment(decimal amount)
        {
            Console.WriteLine($"Credit card payment of {amount} has been refunded");
        }
        public void MakeUPIPayment(decimal Amount)
        {
            Console.WriteLine($"Credit card  UPI payment of {Amount} has been made");
        }
    }

    public class PayPalPpayment : ITestInterface2
    {
        public void MakeUPIPayment(decimal Amount)
        {
            Console.WriteLine($"PayPal UPI payment of {Amount} has been made");
        }
    }

    internal class TestInterface
    {
        static void Main()
        {
            ITestInterface1 creditcard = new CreditCardPayment();
            creditcard.MakePayment(1000.54m);
            creditcard.refundPayment(100.23m);

            ITestInterface2 creditcard2 = new CreditCardPayment();
            creditcard2.MakeUPIPayment(304.54m);


            ITestInterface2 paypal = new PayPalPpayment();
            paypal.MakeUPIPayment(290.454m);
            
        }
    }
}
