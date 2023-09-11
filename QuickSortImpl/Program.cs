using QuickSortImpl;

int[] list = { 20, 26, 93, 17, 77, 31, 44, 55, 54 };
Console.WriteLine("Original list = [" + string.Join(", ", list) + "]");

QuickSort_2.Sort(list);
Console.WriteLine("Sorted list = [" + string.Join(", ", list) + "]");
