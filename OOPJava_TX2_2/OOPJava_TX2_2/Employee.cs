using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    public class Employee : Person //Kế thừa class Person
    {
        private int salary;
        public Employee(int salary, string name, string address):base(name, address)
        {
            this.salary = salary;
        }

        public int getSalary() { return salary; }
        public override void display() //Ghi đè phương thức display của lớp cha Person
        {
            Console.WriteLine($"Name: {getName()}, Address: {getAddress()}, Salary: {salary}");
        }
    }
}
