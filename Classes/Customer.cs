using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string _lastName;
        public string LastName { 
            get {
                return "Mr. " + _lastName; 
            } 
            set { 
                _lastName = value;
            } 
        }
        public string City { get; set; }
    }
}
