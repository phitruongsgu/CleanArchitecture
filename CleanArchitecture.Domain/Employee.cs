using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get;set; }
        public string Name { get;set; } 
        public string? Address { get;set; }
    }
}