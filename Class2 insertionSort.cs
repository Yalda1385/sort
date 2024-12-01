public class InsertionSort<T> : ISorter<T> where T : IComparable<T>
{
    public void SortAscending(T[]array)
    {
        int n = array.Length;
        for (int i = 1; i < n;i++)
        {
            T key = array[i];
            int j = i - i;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = array[j];
            j = j - 1;
        }
        array[j + 1] = Key;
    }
}

public void SortDescending(T[] array)
{
    int n = array.Length;
    for (int i = 1; i < n; i++)
    {
        T key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j].CompareTo(key) < 0)
        {
            array[j + 1] = array[j];
            j = j - 1;
        }
    }
    array[j + 1] = Key;
}