namespace Sorting
{
    internal abstract class Code
    {
        private static void Main()
        {
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("How many columns?: ");
            int columns = Convert.ToInt16(Console.ReadLine());

            Console.Write("What symbol?: ");
            char sign = Convert.ToChar(Console.Read());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}

