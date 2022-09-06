Console.Write("Введите массив чисел: ");

string inputString = Console.ReadLine();
string[] words = inputString.Split(' ', ',');
string[] outputString = new string[inputString.Length] ;

for(int i = 0; i < words.Length; i++ )
{
    if(words[i].Length <= 3)
    { 
        outputString[i] = words[i];
    }
}

Console.WriteLine("[" + string.Join(" ",inputString) + "]");
Console.WriteLine("[" + string.Join(" ",outputString) + "]");

void printArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
{
	Console.Write( array[i] + " ");
}
//	Console.WriteLine();
}
