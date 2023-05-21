using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Worker : IEmployee
    {
        private string name;
        private int days;

        public Worker(string name, int days)
        {
            this.name = name;
            this.days = days;
        }

        void IEmployee.EntitledVacationDays()
        {
            Console.WriteLine(name + " is entitled to take " + days + " vacation days");
        }
    }
}
