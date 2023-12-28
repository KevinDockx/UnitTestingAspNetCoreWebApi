using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.DataAccess.Entities;

/// <summary>
/// Base class for all employees
/// </summary>
public abstract class Employee(
    string firstName,
    string lastName)
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = firstName;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = lastName;

    [NotMapped]
    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }
}
