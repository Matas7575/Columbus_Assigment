namespace Solution3;

public class Assigment3
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(100);
        List<int> duplicates = FindDuplicates(numbers);

        Console.WriteLine("Generated Array:");
        PrintArray(numbers);

        Console.WriteLine("\nDuplicate Numbers:");
        PrintArray(duplicates.ToArray());
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

    static List<int> FindDuplicates(int[] array)
    {
        List<int> duplicates = new List<int>();
        HashSet<int> uniqueValues = new HashSet<int>();

        foreach (int number in array)
        {
            if (!uniqueValues.Add(number))
            {
                if (!duplicates.Contains(number))
                {
                    duplicates.Add(number);
                }
            }
        }

        return duplicates;
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