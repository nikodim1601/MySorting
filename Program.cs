// See https://aka.ms/new-console-template for more information

namespace MyPropProject;

public static class ArrayMerger
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Example One");
        var arr1 = new[] { 6, 12, 53, 88 };
        var arr2 = new[] { 1, 2, 3, 4 };
        var mergedAndSortedArrayOne = ExampleOne.MergeAndSortArrays(arr1, arr2);
        Console.WriteLine(string.Join(", ", mergedAndSortedArrayOne));
        
        Console.WriteLine("Example Two");
        var arr3 = new[] { 6, 12, 53, 88, 11 };
        var arr4 = new[] { 1, 2, 3, 4 };
        var mergedAndSortedArrayTwo = ExampleTwo.MergeAndSortArrays(arr3, arr4);
        Console.WriteLine(string.Join(", ", mergedAndSortedArrayTwo));
    }
}