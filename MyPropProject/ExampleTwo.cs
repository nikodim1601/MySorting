namespace MyPropProject;

public class ExampleTwo
{
    public static int[] MergeAndSortArrays(int[] arr1, int[] arr2)
    {
        // Обьявляю новый массив
        var sortedArr = new int[arr1.Length + arr2.Length];
        
        var indexOfArr1 = 0;
        var indexOfArr2 = 0;
        
        // Идея следующая: я прохожусь по массиву и заполняю его элементами. На каждой итерации я сравниваю элементы и
        // выбираю наименьший элемент из двух. Затем этот наименьший сравниваю с предыдущим и меняю их местами пока.
        // Повторяю свап в цикле, пока элементы не будут упорядочены.
        for (var indexOfSortedArr = 0; indexOfSortedArr < sortedArr.Length; indexOfSortedArr++)
        {
            // Если индекс превышает длинну массива, я заполняю его элементом из другого массива. 
            if (indexOfArr2 > arr2.Length - 1)
            {
                sortedArr = AddElement(sortedArr, indexOfSortedArr, arr1[indexOfArr1] );
                indexOfArr1++;
                continue;
            }
            
            // Если индекс превышает длинну массива, я заполняю его элементом из другого массива.
            if (indexOfArr1 > arr1.Length - 1)
            {
                sortedArr = AddElement(sortedArr, indexOfSortedArr, arr2[indexOfArr2]);
                indexOfArr2++;
                continue;
            }
    
            // Если индекс превышает длинну массива, я заполняю его элементом из другого массива.
            if (arr1[indexOfArr1] <= arr2[indexOfArr2])
            {
                sortedArr = AddElement(sortedArr, indexOfSortedArr, arr1[indexOfArr1]);
                indexOfArr1++;
            }
            else
            {
                sortedArr = AddElement(sortedArr, indexOfSortedArr, arr2[indexOfArr2]);
                indexOfArr2++;    
            }
        }
    
        return sortedArr;
    }

    
    /// <summary>
    /// Добавляет элемент на указанное место.
    /// </summary>
    /// <param name="arr">Массив.</param>
    /// <param name="index">Индекс элемента на который нужно его добавить.</param>
    /// <param name="newValue">Новое значение</param>
    /// <returns></returns>
    private static int[] AddElement(int[] arr, int index, int newValue)
    {
        arr[index] = newValue;
        
        // Если есть предыдущие элемены, происходит проверка на необходимость поменять элемены местами.
        if (index > 0)
        {
            var prevValue = arr[index - 1];
            
            // если предыдущий элемент больше нового, их нужно поменять местами.
            if (prevValue > newValue)
            {
                arr = Swap(arr, index);
            }
        }
        
        return arr;
    }

    /// <summary>
    /// Функция меняет элементы местами до тех пор, пока предыдущий элемент не окажется меньше, чем тот, что нужно установить.
    /// </summary>
    /// <param name="arr">Массив элементов.</param>
    /// <param name="index">Индекс элемента, который нужно поменять местами.</param>
    private static int[] Swap(int[] arr, int index)
    {
        if (index >= 1 && (arr[index - 1] >= arr[index] || index == 1))
        {
            (arr[index], arr[index - 1]) = (arr[index - 1], arr[index]);
            Swap(arr, index - 1);
        }

        return arr;
    }
    
}
