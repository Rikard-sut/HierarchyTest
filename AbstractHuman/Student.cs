using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Student : Human
    {
        private string grade;

        public Student(string firstName, string lastName, string grade) : base(firstName, lastName)
        {
            this.grade = grade;
        }
        public string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public override string ToString()
        {
            return base.ToString("Grade: " + this.grade);
        }
    }
}
