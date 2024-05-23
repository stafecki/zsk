using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_dziedziczenie.classes
{
    internal class MachineSimulator
    {
        private List<Machine> Machines = new List<Machine>();
        public void AddMachine(Machine machine)
        {
            Console.WriteLine($"{machine.Name} została dodana");
            Machines.Add(machine);
        }
        public void StartAll()
        {
            if (Machines.Count == 0)
            {
                Console.WriteLine("Brak maszyn");
                return;
            }
            foreach (var machine in Machines)
            {
                machine.Start();
            }
        }
        public void WorkAll()
        {
            if (Machines.Count == 0)
            {
                Console.WriteLine("Brak maszyn");
                return;
            }
            foreach (var machine in Machines)
            {
                machine.Work();
            }
        }
        public void StopAll()
        {
            if (Machines.Count == 0)
            {
                Console.WriteLine("Brak maszyn");
                return;
            }
            foreach (var machine in Machines)
            {
                machine.Stop();
            }
        }

    }
}
