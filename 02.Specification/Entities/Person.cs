using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public abstract class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public DateTime BirthDate { get; set; }
        public string ForeName { get; set; }
        public string SureName { get; set; }
        public int IdentificationNumber { get; set; }
    }
}
