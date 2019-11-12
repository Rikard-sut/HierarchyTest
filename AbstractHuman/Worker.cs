using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Worker : Human
    {
        private const int defaultWorkDaysInWeek = 5;
        
        private int weekSalary;
        private int workHoursPerDay;
        private int workDaysInWeek;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay, int workDaysInWeek = defaultWorkDaysInWeek)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
            this.workDaysInWeek = workDaysInWeek;
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
        public int WorkDaysInWeek
        {
            get { return this.workDaysInWeek; }
            set { this.workDaysInWeek = value; }
        }
        public double MoneyPerHour()
        {
           return this.weekSalary/this.workDaysInWeek /this.workHoursPerDay;
        }

    }
}
