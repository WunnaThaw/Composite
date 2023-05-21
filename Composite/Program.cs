using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker a = new Worker("Worker Tun", 5);
            Supervisor b = new Supervisor("Supervisor Chris", 6);
            Supervisor c = new Supervisor("Supervisor Khin", 7);
            Supervisor d = new Supervisor("Supervisor Aye Aye", 6);
            Worker e = new Worker("Worker Hla Hla", 3);

            //set up the relationships
            b.AddSubordinate(a); //Tun works for Chris
            c.AddSubordinate(b); //Chris works for Khin
            c.AddSubordinate(d); //Aye Aye works for Khin
            d.AddSubordinate(e); //Hla Hla works for Aye aye

            //Khin's entitled vacation days and her subordinates'
            if (c is IEmployee)
                (c as IEmployee).EntitledVacationDays();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
