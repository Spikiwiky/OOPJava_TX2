using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    internal class PartTimeEmployee : Employee //kế thừa lớp Employee
    {
        public int workingHours { get; set; }

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }
        public override int calculateSalary() //Ghi đè phương thức calculateSalary của lớp cha Employee
        {
            return workingHours * getPaymentPerHour();
        }

        public override string ToString() //Ghi đè phương thức toString của lớp cha Employee
        {
            return $"Name: {getName()}, Payment per hours: {getPaymentPerHour()}, Working Hours: {workingHours}, Salary: {calculateSalary()}";
        }
    }

}
