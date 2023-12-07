namespace listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(-1);
            ints.Add(100);

            Console.WriteLine("Długość listy {0}", ints.Count);
            ints.Add(-50);
            Console.WriteLine("Długość listy {0}", ints.Count);

            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            ints.Remove(-1);

            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            ints.Remove(1);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();*/

            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++) 
            {
                Random losuj = new Random();
                list.Add(losuj.Next(1, 101));
            }
            Console.WriteLine("Losowe");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }

            List<int> podzielne35 = PodzielnePrzez3i5(list);
            
            Console.WriteLine("\nPodzielne przez 3 i 5");
            foreach (int item in podzielne35)
            {
                Console.Write($"{item} ");
            }

            
        }
        public static List<int> PodzielnePrzez3i5(List<int> lista)
        {
            List<int> podzielne = new List<int>();
            for(int i = 0; i<lista.Count; i++) 
            {
                if (lista[i]%3==0 || lista[i] % 5 == 0)
                {
                    podzielne.Add(lista[i]);
                }
            }
            return podzielne;
        }
    }
}
