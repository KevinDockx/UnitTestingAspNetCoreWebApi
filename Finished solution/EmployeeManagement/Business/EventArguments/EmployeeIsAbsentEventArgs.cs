namespace EmployeeManagement.Business.EventArguments;

public class EmployeeIsAbsentEventArgs(Guid employeeId) : EventArgs
{
    public Guid EmployeeId { get; private set; } = employeeId;
}
