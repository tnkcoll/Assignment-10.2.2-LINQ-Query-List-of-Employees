namespace Assignment_10._2._2_LINQ_Query_List_of_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employee>();

            employeeList.Add(new Employee("Ted", 46, 10000.00));
            employeeList.Add(new Employee("Nicole", 40, 9000.00));
            employeeList.Add(new Employee("Kaylee", 22, 8000.00));
            employeeList.Add(new Employee("Ava", 18, 7000.00));
            employeeList.Add(new Employee("Milo", 18, 3000.00));


            //Get all employees who make more than $5000 and are under the age of 30.
            var employeeQuery = from employee in employeeList 
                                where employee.Salary > 5000.00 && employee.Age < 30
                                select employee;

            foreach (var emp in employeeQuery)
            {
                Console.WriteLine("{0}, ${1}, {2}", emp.Name, emp.Salary, emp.Age);
            }
        }
    }
}
