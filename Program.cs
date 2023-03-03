// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int MinSwap(int[] arr)
{
    int n = arr.Length;
    int swapCount = 0;

    // create a dictionary to store the index of each element
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < n; i++)
    {
        dict[arr[i]] = i;
    }

    // sort the array
    Array.Sort(arr);

    for (int i = 0; i < n; i++)
    {
        // check if the current element is in its correct position
        if (dict[arr[i]] != i)
        {
            // swap the current element with the element at its correct position
            int temp = arr[i];
            arr[i] = arr[dict[arr[i]]];
            arr[dict[temp]] = temp;

            // update the dictionary
            dict[temp] = dict[arr[i]];
            dict[arr[i]] = i;

            // increment the swap count
            swapCount++;
        }
    }

    return swapCount;
}
int[] nums = { 3, 3, 1, 4 };

Console.WriteLine("The array swap value is " + MinSwap(nums));