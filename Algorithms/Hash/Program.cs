using System;
using System.Collections.Generic;

namespace Hash {

    class Employee {

       string name;
       int id;
       string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args) {
            Employee employee = new Employee("Tina", 3827, "Technology");
            Employee employee2 = new Employee("Bob", 5324, "Marketing");
            Employee employee3 = new Employee("Linda", 9358, "Sales");

            Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();
            employeesById.Add(employee.id, employee);
            employeesById.Add(employee2.id, employee2);
            employeesById.Add(employee3.id, employee3);

            Employee e;
            if (employeesById.TryGetValue(9358, out e)) {
                Console.WriteLine(e.name + " : " + e.department);
            }

            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("9F20B");
            productCodes.Add("78R21");
            productCodes.Contains("9F20B");
            productCodes.Contains("1F20B");
        }

    }
}
