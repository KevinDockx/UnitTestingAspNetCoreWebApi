using EmployeeManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Test
{
    public class EmployeeTests
    {
        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameIsConcatenation()
        {
            var employee = new InternalEmployee("David", "Lam", 0, 2500, false, 1);

            employee.FirstName = "Lucia";
            employee.LastName = "SHELTON";

            Assert.Equal("Lucia Shelton", employee.FullName, ignoreCase: true);
        }

        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameStartsWithFirstName()
        {
            var employee = new InternalEmployee("David", "Lam", 0, 2500, false, 1);

            employee.FirstName = "Lucia";
            employee.LastName = "SHELTON";

            Assert.StartsWith(employee.FirstName, employee.FullName);
        }

        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameEndsWithLastName()
        {
            var employee = new InternalEmployee("David", "Lam", 0, 2500, false, 1);

            employee.FirstName = "Lucia";
            employee.LastName = "SHELTON";

            Assert.EndsWith(employee.LastName, employee.FullName);
        }

        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameContainsPartOfConcatenation()
        {
            // Arrange
            var employee = new InternalEmployee("Kevin", "Dockx", 0, 2500, false, 1);

            // Act
            employee.FirstName = "Lucia";
            employee.LastName = "Shelton";

            // Assert
            Assert.Contains("ia Sh", employee.FullName);
        }

        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameSoundsLikeConcatenation()
        {
            // Arrange
            var employee = new InternalEmployee("Kevin", "Dockx", 0, 2500, false, 1);

            // Act
            employee.FirstName = "Lucia";
            employee.LastName = "Shelton";

            // Assert
            Assert.Matches("Lu(c|s|z)ia Shel(t|d)on", employee.FullName);
        }
    }
}
