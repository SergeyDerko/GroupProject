using System;
using System.Collections.Generic;

namespace _402_Advanced_programming.Model
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public string SName { get; set; }
        public DateTime Birthday { get; set; }
    }

    interface IEmployee
    {
        string EmployeeId { get; set; }
        string Login { get; set; }
        string Password { get; set; }
    }

    class Employee : Person, IEmployee
    {
        private sealed class EmployeeIdLoginPasswordEqualityComparer : IEqualityComparer<Employee>
        {
            public bool Equals(Employee x, Employee y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return string.Equals(x.EmployeeId, y.EmployeeId) && string.Equals(x.Login, y.Login) && string.Equals(x.Password, y.Password);
            }

            public int GetHashCode(Employee obj)
            {
                unchecked
                {
                    var hashCode = (obj.EmployeeId != null ? obj.EmployeeId.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Login != null ? obj.Login.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (obj.Password != null ? obj.Password.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }

        private static readonly IEqualityComparer<Employee> EmployeeIdLoginPasswordComparerInstance = new EmployeeIdLoginPasswordEqualityComparer();

        public static IEqualityComparer<Employee> EmployeeIdLoginPasswordComparer
        {
            get { return EmployeeIdLoginPasswordComparerInstance; }
        }

        public string EmployeeId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}