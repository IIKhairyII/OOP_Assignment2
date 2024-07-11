namespace OOP_Assignment2.Aggregation
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public Employee[]? Employees { get; set; }

        public Department(int id, string deptName, Employee[]? employees)
        {
            Id = id;
            DeptName = deptName;
            Employees = employees;
        }
    }
}
