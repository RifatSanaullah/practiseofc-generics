using System;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var numbers = new List<int>(10);
            var capacity = -1;
            
            while(true)
            {
                if(numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(capacity);
                }
                numbers.Add(1);
            };*/

            Queue<Employee> employees = new Queue<Employee>();
            employees.Enqueue(new Employee { name = "Alex" });
            employees.Enqueue(new Employee { name = "harry" });
            employees.Enqueue(new Employee { name = "potter" });

            while (employees.Count > 0)
            {
                var employee = employees.Dequeue();
                Console.WriteLine(employee.name);
            }

            Console.WriteLine("?..........?");


            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee { name = "Alex" });
            stack.Push(new Employee { name = "harry" });
            stack.Push(new Employee { name = "potter" });

            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee.name);
            }

            Console.WriteLine("/....../");

            HashSet<Employee> set = new HashSet<Employee>();
            var employeename = new Employee { name = "Alex"};

            set.Add(employeename);
            set.Add(employeename);

            foreach(var item in set)
            {
                Console.WriteLine(item.name);
            }

            var employeeByDepartment = new Dictionary<string, List<Employee>>();
            employeeByDepartment.Add("Engineering", new List<Employee> () { new Employee { name = "Rifat" } });


            employeeByDepartment["Engineering"].Add(new Employee { name = "Joy" });

            




        }
    }
}
