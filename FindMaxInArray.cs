using System;
class FindMaxInArray
{
    static void Main()
    {
        Console.WriteLine("Enter the length of your array...");
        int n = int.Parse(Console.ReadLine());
        int[] arrayName = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.WriteLine("Now enter value of this cell");
            arrayName[index] = int.Parse(Console.ReadLine());
        }
   
        int? maxVal = null; 
        int indexx = -1;
        for (int i = 0; i < arrayName.Length; i++)
        {
            int thisNum = arrayName[i];
            if (!maxVal.HasValue || thisNum > maxVal.Value)
            {
                maxVal = thisNum;
                indexx = i;
            }          
        }
        Console.WriteLine("The maximum index from the array is " + maxVal);
    }
}

