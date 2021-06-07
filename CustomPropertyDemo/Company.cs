using System.Collections.Generic;

namespace CustomPropertyDemo
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
