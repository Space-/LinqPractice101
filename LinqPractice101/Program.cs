using System;

namespace LinqPractice101
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinqSamples samples = new LinqSamples();

            #region Restriction Operators

            //            samples.Linq1();
            //            samples.Linq2();
            //            samples.Linq3();
            //            samples.Linq4();
            //            samples.Linq5();

            #endregion Restriction Operators

            #region Projection Operators

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

            #endregion Projection Operators

            #region Partitioning Operators

            //            samples.Linq20();
            //            samples.Linq20_extend_by_me();
            //            samples.Linq21();
            //            samples.Linq22();
            //            samples.Linq23();
            //            samples.Linq24();
            //            samples.Linq25();
            //            samples.Linq26();
            //            samples.Linq27();

            #endregion Partitioning Operators

            #region Ordering Operators

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

            #endregion Ordering Operators

            #region Grouping Operators

            //            samples.Linq40();
            //            samples.Linq41();
            //            samples.Linq42();
            //            samples.Linq43();
            //            samples.Linq44();
            //            samples.Linq45();

            #endregion Grouping Operators

            #region Grouping Operators

            //            samples.Linq46();
            //            samples.Linq47();
            //            samples.Linq48();
            //            samples.Linq49();
            //            samples.Linq50();
            //            samples.Linq51();
            //            samples.Linq52();
            //            samples.Linq53();

            #endregion Grouping Operators

            #region Conversion Operators

            //            samples.Linq54();
            //            samples.Linq55();
            //            samples.Linq56();
            //            samples.Linq57();

            #endregion Conversion Operators

            #region Element Operators

            //            samples.Linq58();
            //            samples.Linq59();
            //            samples.Linq61();
            //            samples.Linq62();
            //            samples.Linq64();

            #endregion Element Operators

            #region Generation Operators

            //            samples.Linq65();
            //            samples.Linq66();

            #endregion Generation Operators

            #region Quantifiers

            //            samples.Linq67();
            //            samples.Linq69();
            //            samples.Linq70();
            //            samples.Linq72();

            #endregion Quantifiers

            #region Aggregate Operators

            //            samples.Linq73();
            //            samples.Linq74();
            //            samples.Linq76();
            //            samples.Linq77();
            //            samples.Linq78();
            //            samples.Linq79();
            //            samples.Linq80();
            //            samples.Linq81();
            //            samples.Linq82();
            //            samples.Linq83();
            //            samples.Linq84();
            //            samples.Linq85();
            //            samples.Linq86();
            samples.Linq87();

            #endregion Aggregate Operators

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