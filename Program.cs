namespace L14_csi120
{
    internal class Program
    {
        // Kady Tran
        // 6/1/2024


        // 2D Array - Matrix
        // 1 2 3 4 5
        // 6 7 8 9 10
        // datatype[,] name = new datatype[sizeX,sizeY];
        // In trials X represents different trials, Y represents our fields
        static int[,] intMatrix = new int[3,3];
        static int[,] randomMatrix;

        static void Main(string[] args)
        {
            randomMatrix = PopulateIntMatrix(5, 5);
            DisplayMatrix(randomMatrix);

            Console.WriteLine("Diagonal: ");
            for (int x = 0; x < randomMatrix.GetLength(0); x++)
            {
                Console.WriteLine(randomMatrix[x, x] + " ");
            }


        } // End of Main

        // You will create a program, method, that when you pass in a 2D array of char
        // char[3,3]

        // You will check to see if the 2D array is a winning game of tic tac toe

        public static int[,] PopulateIntMatrix(int xSize, int ySize)
        {
            int[,] temp = new int[xSize, ySize];
            Random rand = new Random();

            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(0); y++)
                {
                    temp[x, y] = rand.Next(1, 100);
                }
            }
            return temp;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            int xAxisLength = matrix.GetLength(0);
            int yAxisLength = matrix.GetLength(1);

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.Write(matrix[x, y] + " ");

                }
                Console.WriteLine();
            }
        }

        public static void FirstMatrixExample()
        {
            // Array.GetLongLength(dimension)
            Console.WriteLine(intMatrix.GetLongLength(0));

            int xAxisLength = intMatrix.GetLength(0);
            int yAxisLength = intMatrix.GetLength(1);

            intMatrix[0, 0] = 876;
            intMatrix[1, 0] = 123;

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.WriteLine(intMatrix[x, y]);

                }
            }
        }

        public static void NestedLoopsExample()
        {
            // Nested Loops and Matricies

            // Nested Loops
            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ": ");

                // Place another loop INSIDE of our first loop
                for (int j = 0; j < 8; j++) // We are using j because we already are using i outside of this for loop
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }


        // -------------

    } // Class
} // Namespace
