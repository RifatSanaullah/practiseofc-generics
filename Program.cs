using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace src
{
    public class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
    {

        int IComparer<Employee>.Compare(Employee x, Employee y)
        {
            return String.Compare(x.name, y.name);
        }

        bool IEqualityComparer<Employee>.Equals(Employee x, Employee y)
        {
            return String.Equals(x.name, y.name);
        }

        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            return obj.name.GetHashCode();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Action<bool> print = d => Console.WriteLine(d);
            Func<double, double> square = d => d * d;
            Func<double, double, double> add = (x, y) => x + y;
            Predicate<double> isLessThanTen = d => d < 10;
            print(isLessThanTen(square(add(1,2))));


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

            /*Queue<Employee> employees = new Queue<Employee>();
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
            }*/

            var departments = new SortedDictionary <string, SortedSet<Employee>>();

            departments.Add("sales", new SortedSet<Employee>(new EmployeeComparer()));
            departments["sales"].Add(new Employee { name = "joy" });


            departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Engineering"].Add(new Employee { name = "jason" });
            departments["Engineering"].Add(new Employee { name = "makki" });


            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach(var employee in department.Value)
                {
                    Console.WriteLine("      " + employee.name);
                }
            }
        }
    }
}
