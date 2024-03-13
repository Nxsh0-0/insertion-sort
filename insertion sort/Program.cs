internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 4, 3, 6, 5, 1, 7, 2 };
    }
    private static int[] InsertionSort(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                // Swap if the element at j - 1 position is greater than the element at j position
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray; // Return the sorted array
    }
}