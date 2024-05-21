namespace OOPJava_TX2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo 2 list để lưu thông tin của các employee và customer
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Find Employee with Highest Salary");
                Console.WriteLine("4. Find Customer with Lowest Balance");
                Console.WriteLine("5. Search Employee by Name");
                Console.WriteLine("6. Exit");

                int choice = 0;
                Boolean checkValidChoice = false;
                //Check nhập choice
                while (!checkValidChoice)
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        checkValidChoice = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid choice. Please input again.");
                    }
                }
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter employee name: ");
                            string name = Console.ReadLine();
                            //check nhập tên trống
                            if (name.Trim() == "" || name == null)
                            {
                                throw new Exception();
                            }
                            //check nhập tên trùng
                            foreach (Employee emp in employees)
                            {
                                if(name.Equals(emp.getName(), StringComparison.OrdinalIgnoreCase))
                                {
                                    throw new Exception();
                                }
                            }
                            //check nhập địa chỉ trống
                            Console.WriteLine("Enter employee address: ");
                            string address = Console.ReadLine();
                            if (address.Trim() == "" || address == null)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine("Enter salary: ");
                            int salary = int.Parse(Console.ReadLine());
                            employees.Add(new Employee(salary, name, address));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid data. Please input again.");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter customer name: ");
                            string name = Console.ReadLine();
                            //check nhập tên trống
                            if (name.Trim() == "" || name == null)
                            {
                                throw new Exception();
                            }
                            //check nhập tên trùng
                            foreach (Customer cus in customers)
                            {
                                if (name.Equals(cus.getName(), StringComparison.OrdinalIgnoreCase))
                                {
                                    throw new Exception();
                                }
                            }
                            Console.WriteLine("Enter customer address: ");
                            string address = Console.ReadLine();
                            //check nhập địa chỉ trống
                            if (address.Trim() == "" || address == null)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine("Enter customer balance: ");
                            int balance = int.Parse(Console.ReadLine());
                            customers.Add(new Customer(balance, name, address));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid data. Please input again.");
                        }
                        break;

                    case 3:
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No employees found.");
                        }
                        else
                        {
                            //gán biến lưu số lương và nhân viên có số lương cao nhất cho đối tượng đầu tiên trong list
                            Employee highestSalaryEmployee = employees[0];
                            int highestSalary = employees[0].getSalary();
                            //check và gán giá trị khi có người cao hơn
                            foreach (var emp in employees)
                            {
                                if (emp.getSalary() > highestSalary)
                                {
                                    highestSalary = emp.getSalary();
                                    highestSalaryEmployee = emp;
                                }
                            }
                            //In ra nhân viên có lương cao nhất
                            highestSalaryEmployee.display();
                        }
                        break;

                    case 4:
                        if (customers.Count == 0)
                        {
                            Console.WriteLine("No customers found.");
                        }
                        else
                        {
                            //gán biến lưu số tài khoản và khách hàng sở hữu cho đối tượng đầu tiên trong list
                            Customer lowestBalanceCustomer = customers[0];
                            int lowestBalance = customers[0].getBalance();
                            //check và gán giá trị kho có người thấp hơn
                            foreach (var cus in customers)
                            {
                                if (cus.getBalance() < lowestBalance)
                                {
                                    lowestBalance = cus.getBalance();
                                    lowestBalanceCustomer = cus;
                                }
                            }
                            //in ra
                            lowestBalanceCustomer.display();
                        }
                        break;
                    case 5:
                        Console.Write("Enter name to search: ");
                        Boolean found = false;
                        Boolean checkValidName = false;
                        string searchName = "";
                        //check bỏ trống searchName
                        while (!checkValidName)
                        {
                            try
                            {
                                searchName = Console.ReadLine();
                                if (searchName.Trim() == "" || searchName == null)
                                {
                                    throw new Exception();
                                }
                                checkValidName = true;
                            }catch (Exception e)
                            {
                                Console.WriteLine("Input name can't be empty.");
                            }
                        }
                        //loop và kiếm tra đối tượng có tên match
                        foreach (var emp in employees)
                        {
                            if (emp.getName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                emp.display();
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Employee not found.");
                        }

                        break;
                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}