public class SelectionSort<T> : ISorter<T> where T : IComparable<T>
{
    public void SortAscending(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j=i + 1; j < n; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                    minIndex = j;
            }
            Swap(ref array[i], ref array[minIndex]);
        }
    }
}
public void SortDescending(T[] array)
{
    int n = array.Length;
    for (int i = 0; i < n-1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (array[j].CompareTo(array[maxIndex]) > 0)
                maxIndex = j;
        }
        swap(ref array[i], ref  (array[maxIndex]) > 0)

    }
    private void Swap(ref testc x, ref testc y)
    {
        T temp = x
        x = y;
        y = temp;
    }
}
    

 



