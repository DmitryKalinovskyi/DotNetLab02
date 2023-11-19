using DotNetLab2;



string s = "absaab";
Console.WriteLine($"String {s} contains character a {s.CountOccurence('a')} times");

Console.WriteLine($"{s} but inverted: {s.Invert()}");

void WriteArray<T>(T[] arr, bool endl = true)
{
    foreach (T item in arr)
        Console.Write(item + " ");

    if (endl) Console.WriteLine();
}

int[] arr = new int[] { 1, 2, 10, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"array contains element 10 {arr.CountOccurrence(10)} times");

int[] arr_with_duplicates = new int[] { 1, 1, 2, 2, 3, 4, 3, 4 };

Console.WriteLine("Initial array");
WriteArray(arr_with_duplicates);

int[] arr_without_duplicates = arr_with_duplicates.ClearDuplicates();

Console.WriteLine("Array without duplicates");
WriteArray(arr_without_duplicates);

ExtendedDictionary<string, int, int> someDict = new();

someDict["kek"] = new(1, 2);
someDict["keka"] = new(2, 3);

foreach(var item in someDict)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Does (1, 2) == (1, 2) {new ExtendedDictionaryElement<int, int>(1, 2).Equals(new ExtendedDictionaryElement<int, int>(1, 2))}");

Console.WriteLine($"Does dict contains (1, 2)? {someDict.ContainsValue(new(1, 2))}");
Console.WriteLine($"Does dict contains (3, 2)? {someDict.ContainsValue(new(3, 2))}");
Console.WriteLine($"Does dict contains (3, 4)? {someDict.ContainsValue(new(3, 4))}");