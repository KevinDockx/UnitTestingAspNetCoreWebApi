namespace EmployeeManagement.DataAccess.Entities;

public class ExternalEmployee(
    string firstName,
    string lastName,
    string company) : Employee(firstName, lastName)
{
    public string Company { get; set; } = company;
}
