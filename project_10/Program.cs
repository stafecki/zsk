namespace project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[4, 3];
            Console.Write(ints.Rank); //2
            Console.WriteLine(ints.Length); //12
            Console.WriteLine(ints.GetLength(0)); //4
            Console.WriteLine(ints.GetLength(1)); //3
            //Console.WriteLine(ints.GetLength(2)); //indexoutofrangeexception
            for(int i = 0; i < ints.GetLength(0); i++)
            {
                for(int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write($"ints[{i},{j}] = {ints[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,,] cubs = new int[4,3,2];
            for(int i = 0; i < cubs.GetLength(0); i++)
            {
                Console.WriteLine($"cubs[{i}]");
                for(int j = 0; j < cubs.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcubs[{i},{j}]");
                    for(int k = 0; k < cubs.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcubs[{i},{j},{k}]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int[,] matrix = new int[,] { { 0, 1, 2, 3, 4 } , {5, 6, 7, 8 , 9} , {10, 11, 12, 13, 14 } };
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"matrix[{i},{j}] = {matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            double[,,] cube = new double[,,] { { {1.1,2.1,3.1}, {1.2, 2.2, 3.2 }, {1.3, 2.3, 3.3} }, { {4.1,5.1,6.1}, { 4.2, 5.2, 6.2 }, { 4.3, 5.3, 6.3 } }, { { 7.1, 8.1, 9.1 }, { 7.2, 8.2, 9.2 }, { 7.3, 8.3, 9.3 } } };
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                Console.WriteLine($"cubs[{i}]");
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcubs[{i},{j}]");
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcube[{i},{j},{k}] = {cube[i,j,k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}