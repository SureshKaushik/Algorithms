using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public static class LinqDemo
    {       
        public static void MergeListRemoveDuplicate()
        {
            List<int> list1 = new List<int> { 1, 2, 2, 3 };
            List<int> list2 = new List<int> { 1, 4, 5 };

            var lst1 = list1.Concat(list2).Distinct();
            foreach (var list in lst1)
            {
                Console.Write(list);
            }
        }

        public static void GetListCustomers()
        {
            Product p1 = new Product { ProdId = 301, ProdName = "Deo", Price = 201 };
            Order o1 = new Order { OrderID = 201, products = p1 };
            Order o2 = new Order { OrderID = 202, products = p1 };
            List<Customer> customers = new List<Customer>() 
                { 
                    new Customer { ID = 101, Name = "Suresh", orderId = 201 }, 
                    new Customer { ID = 102, Name = "Manish", orderId = 202 } 
                };

            var query = from cust in customers
                        where cust.orderId == o1.OrderID
                        select new Customer { ID = cust.ID, Name = cust.Name, orderId = cust.orderId};
            
            foreach (var customer in query)
            {
                Console.WriteLine("ID: {0}, Name = {1}, Order ID = {2}", customer.ID, customer.Name, customer.orderId);
            }
        }

        public static void MergeTwoSortedArray()
        {
            int[] A = { 1, 6, 4, 5 };
            int[] B = { 2, 3, 7 };

            int[] arr = new int[A.Length + B.Length];

            A.CopyTo(arr, 0);
            B.CopyTo(arr, A.Length);           

            IEnumerable<int> list = A.Union(B);
            
            foreach (int value in list)
            {
                Console.WriteLine(" " + value);
            }
        }
    }
    public class Customer
    {
        public int ID;
        public string Name;
        public int orderId;
    }
    public class Order
    {
        public int OrderID;
        public Product products;
    }

    public class Product
    {
        public int ProdId;
        public string ProdName;
        public decimal Price;
    }
}
