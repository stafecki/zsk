using klasy_2.classes;

namespace klasy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            //p1.FirstName = "Janusz";
            p1.SetName("Paweł");
            p1.LastName = "Nowak";
            Console.WriteLine("Imie: " + p1.FirstName);
            Console.WriteLine("Nazwisko: " + p1.LastName);
            
            p1.Address = new Address();
            p1.Address.City = "Poznań";
            p1.Address.Street = "Polna";
            p1.Address.PostalCode = "12345";
            p1.Address.HouseOfNumber = "12a";

            Console.WriteLine($"Imie i nazwisko: {p1.FirstName} {p1.LastName}\nAdres: {p1.Address.GetAddress()}");

            p1.Gender = Gender.mężcyzna;
            Console.WriteLine("Płeć: " + p1.Gender);

            p1.DateOfBirth = DateTime.Now;
            Console.WriteLine(p1.DateOfBirth);//01.02.2024 08:16:42
            Console.WriteLine(p1.DateOfBirth.Year); //2024

            p1.DateOfBirth = new DateTime(2020, 1, 10);//r/d/m
            Console.WriteLine(p1.DateOfBirth);//10.01.2020(m/d/r) 00:00:00

            p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
            Console.WriteLine(p1.DateOfBirth);//10.01.2020 08:19:10

            p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
            Console.WriteLine(p1.DateOfBirth.ToShortDateString());//10.01.2020

            p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
            Console.WriteLine(p1.DateOfBirth.ToLongDateString());//piątek, 10 stycznia 2020

            p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
            Console.WriteLine(p1.DateOfBirth.ToShortTimeString());//08:19

            p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
            Console.WriteLine(p1.DateOfBirth.ToLongTimeString());//08:19:10

            p1.Permission = Permission.User;
            if (p1.Permission == Permission.Administrator)
            {
                Console.WriteLine("Jesteś administratorem");
            }
            else
            {
                Console.WriteLine("Nie jestes administratorem");
            }
            int p1Value = (int)p1.Permission;
            Console.WriteLine(p1Value);//3
            p1.Role = Role.Teacher;
            Console.WriteLine("Rola: "+p1.Role);
            
            Teacher t1 = new Teacher();
            t1.Subjects = new List<string>() { "Matematyka", "Programowanie obietkowe", "Informatyka" };
            t1.Subjects.Add("Geografia");
            t1.GetSubjects();
        }
    }
}
