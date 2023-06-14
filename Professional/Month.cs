using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx2
{
    class Month
    {
        private string monthName;
        private int daysInMonth;

        public string MonthName { get { return monthName; } }
        public int DaysInMonth { get { return daysInMonth; } }

        public Month(string monthName, int daysInMonth)
        {
            this.monthName = monthName;
            this.daysInMonth = daysInMonth;
        }

        public override string ToString()
        {
            return string.Format($"{monthName} = {daysInMonth}");
        }
    }
}
