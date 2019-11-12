using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("firstname cannot be null");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("lastname cannot be null");
                this.lastName = value;
            }
        }
        protected string ToString(string suffix)
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat("Name: {0} {1}", this.firstName, this.lastName).AppendLine();
            info.AppendLine(suffix).Replace(Environment.NewLine, Environment.NewLine + " ");
            return info.TrimEnd().ToString();
        }
    }
}
