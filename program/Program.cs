int[] numbers = {10,3,-7,5,7,2,1};

printArray(numbers);

int minIndex = 0;
int maxIndex = 0;

int min = numbers[0];
int max = numbers[0];
  
void printArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
