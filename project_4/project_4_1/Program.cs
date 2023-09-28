namespace project_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "imIę I nAzwisKO";
            Console.WriteLine(message); //imIę I nAzwisKO

            string messageUpperCase = message.ToUpper();
            Console.WriteLine(messageUpperCase);

            string messageLowerCase = message.ToLower();
            Console.WriteLine(messageLowerCase);

            string name = message.Substring(1);
            Console.WriteLine(name);//mIę I nAzwisKO

            string name1 = message.Substring(0, 4);
            Console.WriteLine(name1);//imIę

            Console.WriteLine(name1[0]); //i

            //imIę I nAzwisKO => Imię i nazwisko
            Console.WriteLine(message.Substring(0,1).ToUpper() + message.Substring(1).ToLower());
            Console.WriteLine(message[0].ToString().ToUpper() + message.Substring(1).ToLower());


        }
    }
}