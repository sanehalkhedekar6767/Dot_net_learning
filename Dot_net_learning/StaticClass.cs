//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dot_net_learning
//{
//    //static class
//    static class Product
//    {
//        //static member
//        public static int productId;
//        public static string productName;
//        public static int productPrice;

//        //static constructor
//        static Product()
//        {
//            productId = 101;
//            productName = "Demo";
//            productPrice = 1000;
//        }

//        //static method
//        public static void GetProductDetails()
//        {
//            Console.WriteLine($"ProductId: {productId}, ProductName: {productName}, ProductPrice: {productPrice}");
//        }

//        public static void GetDiscount()
//        {
//            int discountAmount = productPrice / 10;
//            Console.WriteLine("Your discount amount is ", discountAmount);
//            Console.WriteLine("Total amount of product is ", (productPrice - discountAmount));


//        }
//    }
//    internal class StaticClass
//    {
//        static void Main()
//        {

//            //Product.GetProductDetails();
//            //Product.GetDiscount();
//            //Console.ReadLine();

//        }
//    }
//}
