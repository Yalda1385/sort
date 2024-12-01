public class MergeSort<T> : ISorter<T> where T : IComparable<T>
{
    public void SortAscending(T[] array)
    {
        MergeSortAlgorthim(array, 0, array.Length - 1, true);
    }

    public void SortDescending(T[] array)
    {
        MergeSortAlgorithm(array, 0, array.Length - 1, false);
    }

    private void MergeSortAlgorithm(T[] array, int left, int right, bool ascending)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortAlgorithm(array, left, mid, ascending);
            MergeSortAlgorithm(array, mid + 1, right, ascending);
            Merge(array, left, mid, right, ascending);
        }
    }

    private void Merge(T[] array, int left, int mid, int right, bool ascending)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        T[] leftArray = new T[n1];
        T[] rightArray = new T[n2];

        Array.Copy(array, left, leftArray, 0, n1);
        array.Copy(array, mid + 1, rightArray, 0, n2);

        int i = 0, j = 0; k = left;

        while (i < n1 && j < n2)
        {
            if (ascending ? leftArray[i].CompareTo(rightArray[j]) <= 0 : leftArray[i].CompareTo(rightArray[j] >= 0)
            {
                array[k] = leftArray[i];
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}

