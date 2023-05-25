namespace Solution2;

public class Assigment2
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(100);
        int maxNumber = FindMaxNumber(numbers);

        Console.WriteLine("Generated Array:");
        PrintArray(numbers);

        Console.WriteLine("\nMaximum Number: " + maxNumber);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 1000); // Generate random values between 1 and 1000
        }

        return array;
    }

    static int FindMaxNumber(int[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Array is empty.");
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");

            if ((i + 1) % 10 == 0) // Print 10 numbers per line
            {
                Console.WriteLine();
            }
        }
    }
}