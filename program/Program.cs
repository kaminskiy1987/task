int[] numbers = {10,3,-7,5,7,2,1};

printArray(numbers);

int minIndex = 0;
int maxIndex = 0;

int min = numbers[0];
int max = numbers[0];

int i = 1;
   
while(i < numbers.Length)
{
    if (max < numbers[i])
    {
        max = numbers[i];
        maxIndex = i;
    }

    i++
}  
void printArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
