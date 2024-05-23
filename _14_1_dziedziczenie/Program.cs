using _14_1_dziedziczenie.classes;
namespace _14_1_dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Machine machine = new Machine("M-100");
            Excavator excavator = new Excavator("E-200");
            excavator.Start();
            excavator.Stop("awaria silnika");
            excavator.Work();
            excavator.Dig();*/
            Bulldozer b1 = new Bulldozer("B1");
            Crane c1 = new Crane("C1");
            Excavator e1 = new Excavator("E1");
            Loader l1 = new Loader("L1");
            MachineSimulator ms1 = new MachineSimulator();
            ms1.AddMachine(b1);
            ms1.AddMachine(c1);
            ms1.AddMachine(e1);
            ms1.AddMachine(l1);
            Console.WriteLine();
            ms1.StartAll();
            Console.WriteLine();
            ms1.WorkAll();
            Console.WriteLine();
            ms1.StopAll();
            Console.ReadKey();
        }
    }
}