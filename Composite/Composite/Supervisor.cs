using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Supervisor : IEmployee
    {
        private string name;
        private int days;

        private List<IEmployee> subordinate = new List<IEmployee>();

        public Supervisor(string name, int days)
        {
            this.name = name;
            this.days = days;
        }

        //public void EntitledVacationDays()
        //{

        //}
        void IEmployee.EntitledVacationDays()
        {
            Console.WriteLine(name + " is entitled to take " + days + " vacation days");
            //show all the subordinate's entitled vacation days
            foreach (IEmployee i in subordinate)
                i.EntitledVacationDays();
        }

        public void AddSubordinate(IEmployee employee)
        {
            //if(employee.GetType() is Supervisor)
            //{

            //}
            subordinate.Add(employee);
        }
    }
}
