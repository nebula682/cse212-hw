/*public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return []; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}*/



//My solution//












// 1.  I will create a new double array of size 'length'.
// 2.  I will use a for loop to iterate from 0 to length - 1.
// 3. On each iteration,  will calculate the multiple by multiplying (i+1) * number.
// 4. Then I willStore the calculated value in the array at index i.
// 5. After the loop finishes,  I will return the populated array.







// 1. I will Identify the cutoff point for splitting 
//    This will be data.Count - amount, because we are moving the last 'amount' elements to the front.
// 2. Use GetRange to extract the last 'amount' elements from the list.
// 3. Remove these last 'amount' elements from the original list using RemoveRange.
// 4. Insert the extracted elements at the beginning of the list using InsertRange.
// 5. The list is now rotated in-place to the right by 'amount'.


















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
        // 1. Create a new double array of size 'length'.
        double[] multiples = new double[length];

        // 2. Use a for loop to iterate from 0 to length - 1.
        for (int i = 0; i < length; i++)
        {
            // 3. Calculate the multiple: (i+1) * number.
            multiples[i] = (i + 1) * number;
        }

        // 5. Return the populated array.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// This function modifies the existing data list in-place.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1. Calculate the cutoff index (start of the last 'amount' elements)
        int cutoffIndex = data.Count - amount;

        // 2. Extract the last 'amount' elements using GetRange.
        List<int> tail = data.GetRange(cutoffIndex, amount);

        // 3. Remove the last 'amount' elements from the original list.
        data.RemoveRange(cutoffIndex, amount);

        // 4. Insert the extracted elements at the beginning of the list.
        data.InsertRange(0, tail);

        // Now, the list is rotated in-place to the right by 'amount'.
    }
}