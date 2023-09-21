using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("programowanie");
            Console.WriteLine(" w języku c#");
            /*
             * komentarz w
             * wielu liniach
             */
            //komentarz w jednej lini

            /*typy danych
             * byte 0 do 255 (8 bitów = 1 bajt)
             * sbyte -128 do 127 (8 bitów = 1 bajt)
             * 
             * short -32768 do 32767 (16 bitów = 2 bajty)
             * ushort 0 do 65535 (16 bitów = 2 bajty)
             * 
             * int -2 147 483 648 do 2 147 483 647 (32 bity = 4 bajty, Int32)
             * uint 0 do 4 294 967 295 (32 bity = 4 bajty, Int32)
             * 
             * Int64 = System.Int64 = long
             */
            byte b = 0;
            Console.WriteLine("Zmienna b wynosi: " + b);

            sbyte sb = 127;
            Console.WriteLine($"Zmienna sb wynosi: {sb}");

            short s = -20000;
            ushort us = 10000;
            Console.WriteLine("Zmienna s wynosi {0}, zmienna us wynosi: {1}", s, us);

            Int16 i = 32767; //to samo co short
            Int16 i1 = -32767; //to samo so short

            System.Int64 i2 = 22222222222222;
            
            Console.ReadKey();
        }
    }
}
