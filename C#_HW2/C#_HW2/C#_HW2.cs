namespace HW2
{
    class List
    {
        static void Main()
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            // Using a list
            List<List<double>> numbers = new List<List<double>>();

            for (int i = 0; i < rows; i++) {
                Console.WriteLine($"Row {i + 1}");
                List<double> row = new List<double>();

                for (int j = 0; j < cols; j++) {
                    Console.Write($"Enter number{j + 1}: ");
                    double value = double.Parse(Console.ReadLine());
                    row.Add(value);
                }
                numbers.Add(row);
            }
            Console.WriteLine("\nThe numbers are:");
            double sum = 0;
            int count = 0;

            // calculate sum
            foreach (var row in numbers)
            {
                foreach (var value in row)
                {
                    Console.Write(value.ToString("0.0") + " ");
                    sum += value;
                    count++;
                }
                Console.WriteLine();
            }
            double average = sum / count;
            Console.WriteLine($"\nSum: {sum:0.0}  ;  Average: {average:0.0}");
        }
    }

}
