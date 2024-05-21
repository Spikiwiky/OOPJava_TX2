using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    public abstract class Employee : IEmployee //Kế thừa interface IEmployee
    {
        private String name;
        private int paymentPerHour;

        public Employee(String name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public void setName(String name) { 
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public int getPaymentPerHour()
        {
            return this.paymentPerHour;
        }
      
        public abstract int calculateSalary(); 

        public String toString()
        {
            return "Name: " + name + ", Payment per Hour: " + paymentPerHour;
        }
    }

}
