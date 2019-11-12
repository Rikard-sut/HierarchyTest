using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
        public double MoneyPerHour()
        {
            double money = weekSalary / 5 / workHoursPerDay;
            return money;
        }

    }
}
