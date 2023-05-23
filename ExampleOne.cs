namespace MyPropProject;

public static class ExampleOne
{
    public static int[] MergeAndSortArrays(int[] arr1, int[] arr2)
    {
        // Обьявляю новый массив
        var sortedArr = new int[arr1.Length + arr2.Length];
        
        var indexOfArr1 = 0;
        var indexOfArr2 = 0;

        // Идея следующая: я прохожусь по массиву и заполняю его элементами. На каждой итерации я сравниваю элементы и
        // заполнаю массив наименьшим, увеличивая индекс массива, из которого я взял элемент, чтобы работать со следующим элементом.
        for (var indexOfSortedArr = 0; indexOfSortedArr < sortedArr.Length; indexOfSortedArr++)
        {
            // Если индекс превышает длинну массива, я заполняю его элементом из другого массива. 
            if (indexOfArr2 > arr2.Length - 1)
            {
                sortedArr[indexOfSortedArr] = arr1[indexOfArr1];
                indexOfArr1++;
                continue;
            }

            // Если индекс превышает длинну массива, я заполняю его элементом из другого массива.
            if (indexOfArr1 > arr1.Length - 1)
            {
                sortedArr[indexOfSortedArr] = arr2[indexOfArr2];
                indexOfArr2++;
                continue;
            }
            
            // Сравнивую элементы и увеличиваю индекс массива, элемент которого я добавил в сортированный массив
            if (arr1[indexOfArr1] <= arr2[indexOfArr2])
            {
                sortedArr[indexOfSortedArr] = arr1[indexOfArr1];
                indexOfArr1++;
            }
            else
            {
                sortedArr[indexOfSortedArr] = arr2[indexOfArr2];
                indexOfArr2++;    
            }
        }

        return sortedArr;
    }
}