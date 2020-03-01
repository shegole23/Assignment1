using System;
using System.Collections.Generic;
using System.Text;

namespace quiz1
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int Warnign { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public float Size { get; set; }
        public DateTime ReleseDate { get; set; }
        public string Manufacturier { get; set; }
        public string ManufacturierCountry { get; set; }

        public void Count(int id)
        {
           
        }
    }
}
