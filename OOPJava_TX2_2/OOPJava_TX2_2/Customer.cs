using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    public class Customer : Person //Kế thừa class person
    {
        private int balance;

        public Customer(int balance, string name, string address) : base(name, address)
        {
            this.balance = balance;
        }
        public int getBalance()
        {
            return this.balance;
        }
        public override void display() //Ghi đè phương thức display của lớp cha Person
        {
            Console.WriteLine($"Name: {getName()}, Address: {getAddress()}, Balance: {balance}");
        }
    }
}
