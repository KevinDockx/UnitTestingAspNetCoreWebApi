using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.DataAccess.Entities;

public class Course(string title)
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public bool IsNew { get; set; } = true;
    public string Title { get; set; } = title;
    public List<InternalEmployee> EmployeesThatAttended { get; set; } 
        = [];
}
