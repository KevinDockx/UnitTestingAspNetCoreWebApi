namespace EmployeeManagement.Business.Exceptions;

public class EmployeeInvalidRaiseException(string message, int raise) : Exception(message)
{
    public int InvalidRaise { get; private set; } = raise;
}
