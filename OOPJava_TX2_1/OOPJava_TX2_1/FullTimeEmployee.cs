using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    internal class FullTimeEmployee : Employee //kế thừa lớp Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour) { }

        public override int calculateSalary() //Ghi đè phương thức calculateSalary của lớp cha Employee
        {
            return 8 * getPaymentPerHour();
        }

        public override string ToString() //Ghi đè phương thức toString của lớp cha Employee
        {
            return $"Name: {getName()}, Payment per hours: {getPaymentPerHour()}, Salary: {calculateSalary()}";
        }
    }
}
