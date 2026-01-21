using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'. 
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. 
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Step 1: Create a new array of doubles with the specified 'length'.
        double[] results = new double[length];

        // Step 2: Loop through the array using a for-loop, starting from index 0 up to 'length'.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple. 
            // Since the first multiple is the number itself (number * 1), 
            // we multiply 'number' by (i + 1).
            results[i] = number * (i + 1);
        }

        // Step 4: Return the completed array.
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Step 1: Identify the split point. 
        // The numbers to be moved to the front are the last 'amount' elements.
        // We can calculate the starting index of these elements as: data.Count - amount.
        int splitIndex = data.Count - amount;

        // Step 2: Use GetRange to extract the elements from the split point to the end of the list.
        // These are the elements that "wrap around" to the front.
        List<int> endPart = data.GetRange(splitIndex, amount);

        // Step 3: Remove those same elements from the end of the original list.
        data.RemoveRange(splitIndex, amount);

        // Step 4: Insert the extracted 'endPart' at the very beginning (index 0) of the list.
        data.InsertRange(0, endPart);
        
        // Final result: The list is modified in place, shifting the end elements to the start.
    }
}