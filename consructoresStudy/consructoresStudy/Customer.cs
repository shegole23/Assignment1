using System;
using System.Collections.Generic;
using System.Text;

namespace consructoresStudy
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
        }
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
