using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx3
{
    class FamilyMember
    {
        private string name;
        private DateTime birthday;

        public string Name { get { return name; } }
        public DateTime Birthday { get { return birthday; } }

        public FamilyMember(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return string.Format($"{Name} - {Birthday.ToString("d MMM yyyy")}");
        }
    }
}
