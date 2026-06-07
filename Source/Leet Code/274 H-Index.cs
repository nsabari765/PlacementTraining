public class Solution
{
    public int HIndex(int[] citations)
    {
        int size = citations.Length;
        int temp = 0, hIndex = 0;

        QuickSort(citations, 0, size - 1);

        for (int i = 0; i < size; i++)
        {
            if (citations[i] >= i + 1)
            {
                hIndex++;
            }
        }

        return hIndex;
    }
    
    public void QuickSort(int[] citations, int low, int high)
    {
        if(low < high)
        {
            int partitionIndex = Partition(citations, low, high);
            
            QuickSort(citations, low, partitionIndex - 1);
            QuickSort(citations, partitionIndex + 1, high);
        }
    }
    
    public int Partition(int[] citations, int low, int high)
    {
        int pivot = citations[low];
        int i = low, j = high;
        
        while(i < j)
        {
            if(citations[i] > pivot)
            {
                i++;
            }
            
            if (citations[j] < pivot ||
                (citations[i] == pivot
                    && citations[j] == pivot
                    && i < j))
            {
                j--;
            }
            
            if(citations[i] < citations[j])
            {
                int temp = citations[i];
                citations[i] = citations[j];
                citations[j] = temp;
            }
        }
        
        return j;
    }
}



Current complexity:
O
(
N
l
o
g
N
)
O(NlogN)
Suggested complexity:
O
(
N
)
O(N)
Suggestions:
Switch to counting sort or bucket sort to achieve linear time complexity