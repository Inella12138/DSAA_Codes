int[] a1 = { 1, 3, 2, 4 }, b1 = { 2, 4, 1 };
int[] a2 = { 1, 2, 4 }, b2 = { 2, 4, 1 };
int[] a3 = { 2, 4, 2, 4, 3 }, b3 = { 4, 2, 3, 4, 4 };
int[] a4 = { 2, 4, 2, 4, 3 }, b4 = { 4, 2, 3, 4, 2 };

Console.WriteLine(Compare(a1,b1));
Console.WriteLine(Compare(a2,b2));
Console.WriteLine(Compare(a3,b3));
Console.WriteLine(Compare(a4,b4));


static Dictionary<int,int> CountOccur(int[] arr)
{
    Dictionary<int,int> CountOccurDict = new Dictionary<int,int>();
    //for (int i = 0; i < arr.Length; i++)
    foreach(int num in arr)
    {
        //if (CountOccurDict.ContainsKey(arr[i]))
        if(CountOccurDict.ContainsKey(num))
        {
            //CountOccurDict[arr[i]]++;
            CountOccurDict[num]++;
        }
        else
        {
            CountOccurDict.Add(num, 1);
            //CountOccurDict.Add(arr[i], 1);
        }
    }
    return CountOccurDict;
}

static bool Compare(int[] arr1, int[] arr2)
{
    Dictionary<int, int> dict1 = CountOccur(arr1);
    Dictionary<int, int> dict2 = CountOccur(arr2);
    if (dict1.Count != dict2.Count) { return false; }
    Dictionary<int, int>.KeyCollection keys1 = dict1.Keys;
    foreach (int key1 in keys1)
    {
        if (!dict2.ContainsKey(key1)) { return false; }
        else
        {
            if (dict1[key1] != dict2[key1]) { return false; }
        }        
    }
    return true;
}
