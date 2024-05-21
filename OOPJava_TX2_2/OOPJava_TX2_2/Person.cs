using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    public abstract class Person
    {
        private string name;  
        private string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void setName(string name) 
        {
            this.name =name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setAddress(string address)
        {
            this.address=address;
        }
        public string getAddress()
        {
            return this.address;
        }

        public abstract void display();
    }
}
