using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Partial_Classes
{
    public partial class Student
    {
        private int medicalRecordId;

        public Student(string firstName, string lastName)
        {
            medicalRecordId = -1;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
