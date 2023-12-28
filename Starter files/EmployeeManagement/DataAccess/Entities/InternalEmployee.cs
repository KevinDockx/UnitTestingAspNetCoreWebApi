using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.DataAccess.Entities;

public class InternalEmployee(
    string firstName,
    string lastName,
    int yearsInService,
    decimal salary,
    bool minimumRaiseGiven,
    int jobLevel) : Employee(firstName, lastName)
{
    [Required]
    public int YearsInService { get; set; } = yearsInService;

    [NotMapped]
    public decimal SuggestedBonus { get; set; }

    [Required]
    public decimal Salary { get; set; } = salary;

    [Required]
    public bool MinimumRaiseGiven { get; set; } = minimumRaiseGiven;

    public List<Course> AttendedCourses { get; set; } = [];

    [Required]
    public int JobLevel { get; set; } = jobLevel;
}
