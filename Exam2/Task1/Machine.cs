using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine Started");
        }
    }
    public class MachineSubClass : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Machine Started Successfully");
        }
    }
}
