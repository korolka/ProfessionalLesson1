using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx2
{
    class MonthCollection
    {
        Month[] months;

        public MonthCollection()
        {
            MonthInitialise();
        }

        private void MonthInitialise()
        {
            months = new Month[12];
            months[0] = new Month("January", 31);
            months[1] = new Month("February", 28);
            months[2] = new Month("March", 31);
            months[3] = new Month("April", 30);
            months[4] = new Month("May", 31);
            months[5] = new Month("June", 30);
            months[6] = new Month("July", 31);
            months[7] = new Month("August", 31);
            months[8] = new Month("September", 30);
            months[9] = new Month("October", 31);
            months[10] = new Month("November", 30);
            months[11] = new Month("December", 31);

        }

        public Month this[int index]
        {
            get 
            {
                if(index-1 >= 0 && index-1 < months.Length)
                return months[index-1];
                throw new Exception("Don`t exist number");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return months.GetEnumerator();
        }

    }
}
