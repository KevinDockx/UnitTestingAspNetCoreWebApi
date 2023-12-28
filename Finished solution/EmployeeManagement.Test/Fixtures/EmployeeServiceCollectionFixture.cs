using Xunit;

namespace EmployeeManagement.Test.Fixtures;

[CollectionDefinition("EmployeeServiceCollection")]
public class EmployeeServiceCollectionFixture 
    : ICollectionFixture<EmployeeServiceFixture>
{
}
