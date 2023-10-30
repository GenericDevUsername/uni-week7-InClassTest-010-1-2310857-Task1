namespace _2310857_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define variables
            List<double> numbers = new List<double> { };
            string input;

            // create loop to allow user to input an infinite amount of numbers
            int i = 0; // iter for number count
            while(true)
            {
                Console.Write($"Enter number {i+1}...\nPress enter without entering a number to finish number selection:\n>>> ");
                input = Console.ReadLine(); // take input number {i+1}
                Console.Clear(); // clear console
                try
                {
                    numbers.Add(Convert.ToDouble(input)); // attempt to convert input
                }
                catch
                {
                    // if input it not a number, return invalid input
                    // If input is empty continue to next section
                    if (input == "")
                    {
                        break;
                    }
                    else Console.WriteLine("Invalid Input!\n");
                }
                Console.WriteLine($"[{string.Join(", ", numbers.ToArray())}]");
                i++;
            }

            Console.WriteLine($"\nThe mean of [{string.Join(", ", numbers.ToArray())}] is: {CalculateMean(numbers)}");


        }

        // Calcuate the mean of a list of doubles
        static double CalculateMean(List<double> numbers)
        {
            double temp = 0; // temp value
            // add numbers together
            foreach (double num in numbers)
            {
                temp += num;
            }
            temp = temp / numbers.Count; // deivide by list length

            return temp; // return mean
        }
    }
}