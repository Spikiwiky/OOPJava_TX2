using OOPJava_TX2_1;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace OOPJava_TX2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); //Khai báo list chứa các employee
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Full Time Employee");
                Console.WriteLine("2. Add Part Time Employee");
                Console.WriteLine("3. Find Employee with Highest Salary");
                Console.WriteLine("4. Search Employee by Name");
                Console.WriteLine("5. Exit");
                Boolean validChoice = false;  //Biến check valid khi chọn chức năng từ menu
                int choice = 6;
                //Nếu input sai throw exception và yêu cầu nhập lại chức năng
                while (!validChoice) {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        validChoice = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                switch (choice)
                {
                    case 1: //case 1 nhập thông tin của một fulltime employee
                        try
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            if (name == null || name.Trim() == "")
                            {
                                throw new Exception();
                            }
                            foreach (Employee e in employees) {
                                if(name.Equals(e.getName(), StringComparison.OrdinalIgnoreCase)) {
                                    throw new Exception();
                                }
                            }
                            Console.Write("Enter payment per hour: ");
                            int paymentPerHour = int.Parse(Console.ReadLine());
                            employees.Add(new FullTimeEmployee(name, paymentPerHour));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;

                    case 2: //case 2 nhập thông tin của một parttime employee
                        try
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            if (name==null || name.Trim() == "")
                            {
                                throw new Exception();
                            }
                            foreach (Employee e in employees)
                            {
                                if (name.Equals(e.getName(), StringComparison.OrdinalIgnoreCase))
                                {
                                    throw new Exception();
                                }
                            }
                            Console.Write("Enter payment per hour: ");
                            int paymentPerHour = int.Parse(Console.ReadLine());
                            Console.Write("Enter working hours: ");
                            int workingHours = int.Parse(Console.ReadLine());
                            employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;

                    case 3: //case 3 tìm 2 nhân viên có số lương cao nhất của parttime và fulltime
                        Employee highestFullTime = null;
                        Employee highestPartTime = null;
                        foreach (Employee e in employees)
                        {
                            if (e is FullTimeEmployee)
                            {
                                if (highestFullTime == null || e.calculateSalary() > highestFullTime.calculateSalary())
                                {
                                    highestFullTime = e;
                                }
                            }
                            else if (e is PartTimeEmployee)
                            {
                                if (highestPartTime == null || e.calculateSalary() > highestPartTime.calculateSalary())
                                {
                                    highestPartTime = e;
                                }
                            }
                        }
                        Console.WriteLine("Highest Salary Full Time Employee: " + highestFullTime);
                        Console.WriteLine("Highest Salary Part Time Employee: " + highestPartTime);
                        break;

                    case 4: //case 4 tìm nhân viên theo tên
                        try
                        {
                            Console.Write("Enter name to search: ");
                            string searchName = Console.ReadLine();
                            if (searchName == null || searchName.Trim() == "")
                            {
                                throw new Exception();
                            }
                            foreach (Employee e in employees)
                            {
                                if (e.getName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine(e);
                                }
                            }
                        }catch (Exception e)
                        {
                            Console.WriteLine($"Name can't empty");
                        }
                        break;

                    case 5:
                        return;

                    case 6:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
