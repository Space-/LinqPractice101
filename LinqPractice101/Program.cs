using System;

namespace LinqPractice101
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            //            samples.Linq1();
            //            samples.Linq2();
            //            samples.Linq3();
            //            samples.Linq4();
            //            samples.Linq5();

            //            samples.Linq6();
            //            samples.Linq7();
            //            samples.Linq8();
            //            samples.Linq9();
            //            samples.Linq10();
            //            samples.Linq11();
            //            samples.Linq12();
            //            samples.Linq13();
            //            samples.Linq14();
            //            samples.Linq15();
            //            samples.Linq16();
            //            samples.Linq17();
            //            samples.Linq18();
            //            samples.Linq19();

            //            samples.Linq20();
            //            samples.Linq20_extend_by_me();
            //            samples.Linq21();
            //            samples.Linq22();
            //            samples.Linq23();
            //            samples.Linq24();
            //            samples.Linq25();
            //            samples.Linq26();
            //            samples.Linq27();

            //            samples.Linq28();
            //            samples.Linq29();
            //            samples.Linq30();
            //            samples.Linq31();
            //            samples.Linq32();
            //            samples.Linq33();
            //            samples.Linq34();
            //            samples.Linq35();
            //            samples.Linq36();
            //            samples.Linq37();
            //            samples.Linq38();
            //            samples.Linq39();
            //            samples.Linq40();
            //            samples.Linq41();
            //            samples.Linq42();
            //            samples.Linq43();
            //            samples.Linq44();
            //            samples.Linq45();

            //            samples.Linq46();
            //            samples.Linq47();
            //            samples.Linq48();
            //            samples.Linq49();
            //            samples.Linq50();
            samples.Linq51();

            Console.ReadKey();
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}