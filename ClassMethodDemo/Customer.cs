using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Customer
    {
        public Customer(int id, string name, string surname, bool working)
        {
            id = Id;
            name = Name;
            surname = Surname;
            working = Working;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Working { get; set; }
    }

}
