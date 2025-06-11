using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace Week_10_Assignment_10._2._1
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("WEEK_10_Assignment_10.2.1\n");
            // Write a program in C# Sharp to find the +ve numbers from a list of numbers
            // using where conditions in LINQ Query.
            // Input: { 2, -1, 3, -3, 10, -200}
            // Expected output: { 2, 3, 10}

            // Create a list
            var list = new List<int> { 2, -1, 3, -3, 10, -200 };

            // LINQ to only select positive digits or elements
            List<int>positive_numbers = (from num in list
                                   where num > 0
                                   select num).ToList();
            // Output
            Console.WriteLine("Here is list of the positive elements:");
            Console.Write("{" + string.Join(", ", positive_numbers) + "}\n");

            Console.WriteLine("\nWEEK_10_Assignment_10.2.2\n");
            // Write a program to create a list of employees.
            // Consider a hard coded list.
            // Display all employees who have salary more than $5000 and age < 30.

            // List of Employees from the Employee Class
            List<Employee> employees = new List<Employee>() {
            new Employee() { EmployeeID = 412, EmployeeName = "Dave, Joseph", EmployeeAge = 47, EmployeeSalary = 19000, EmployeeDepartment = "IT Department" },
            new Employee() { EmployeeID = 564, EmployeeName = "Anderson, Noel", EmployeeAge = 25, EmployeeSalary = 1000, EmployeeDepartment = "Finance Department" },
            new Employee() { EmployeeID = 471, EmployeeName = "Kenny, Vincent", EmployeeAge = 27, EmployeeSalary = 4000, EmployeeDepartment = "Customer Service Department" },
            new Employee() { EmployeeID = 254, EmployeeName = "Junior, Norelus", EmployeeAge = 51, EmployeeSalary = 10000, EmployeeDepartment = "Quality Department" },
            new Employee() { EmployeeID = 963, EmployeeName = "Kiana, Oliver", EmployeeAge = 46, EmployeeSalary = 8000, EmployeeDepartment = "Management Department" },
            new Employee() { EmployeeID = 360, EmployeeName = "Davidson, Ramirez", EmployeeAge = 34, EmployeeSalary = 30000, EmployeeDepartment = "Sales Department" },
            new Employee() { EmployeeID = 187, EmployeeName = "Jamison, Dupont ", EmployeeAge = 39, EmployeeSalary = 500, EmployeeDepartment = "Maintenace Department" }
            };

            // LINQ to select from 
            var SeniorEmployee = from emp in employees
                                 where emp.EmployeeAge >= 30 && emp.EmployeeSalary >= 5000
                                 select emp;

            Console.WriteLine("Here are the employee who are over the age of 30 and salary over 5,000 dollars:");
            foreach ( Employee emp in SeniorEmployee)
            { 
                Console.WriteLine($"Age: {emp.EmployeeAge}, Salary: {emp.EmployeeSalary}");
            }

            Console.WriteLine("\nWEEK_10_Assignment_10.2.3\n");
            // Write a program in C# Sharp to find a string that starts and ends with a specific character.
            // Test Data:
            // The cities are: 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
            // Input starting character for the string : A
            // Input ending character for the string : M
            // Expected Output :
            // The city starting with A and ending with M is : AMSTERDAM

            string s  = "ROME, LONDON, NAIROBI, CALIFORNIA, ZURICH, NEW DELHI, AMSTERDAM, ABU DHABI, PARIS";

            string[] words = s.Split(',');
            List<string> strings = words.ToList();

            foreach(string word in words)
            {
                strings.Add(word.Trim());
            }
            
            var newString = from word in strings
                            where word.StartsWith('A') && word.EndsWith('M')
                            select word;

            Console.WriteLine("The city starting with A and ensding with M is AMSTERDAM: ");
            foreach ( var word in newString)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nWEEK_10_Assignment_10.2.4\n");
            // Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
            // Test Data:
            // The members of the list are :
            // 55 200 740 76 230 482 95
            // Expected Output :
            // The numbers greater than 80 are:
            // 200
            // 740
            // 230
            // 482
            // 95

            // Ask user to enter numbers
            Console.Write("Enter numbers separated by spaces: ");
            string input = Console.ReadLine();

            // split numbers and add to list
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();


            // Display the original list
            Console.WriteLine("\nThe members of the list are: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
            // LINQ to find the elements greater than 80
            var result = from num in numbers
                                 where num > 80
                                 select num;

            Console.WriteLine();
            Console.WriteLine("\nThe numbers greater than 80 are: ");
            foreach(var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}

