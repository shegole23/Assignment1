using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = Name;
        }
        public string GetName()
        {
            if(string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }
        public void SetId(int Id)
        {
            if(Id <= 0)
            {
                throw new Exception("Student Id can not be negative");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.SetId(101);
            c1.SetName("Anwar");
            Console.WriteLine("Student Id is {0}", c1.GetId());
            Console.WriteLine("Student Name is {0}", c1.GetName());
        }
    }
}
