using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _03.Visitor.Tests
{
    public class OfficeTests
    {
        [Fact]
        public void Employees_Should_NotBe_Null()
        {
            Office office = new Office();
            Assert.NotNull(office.GetEmployees());
        }
    }
}
