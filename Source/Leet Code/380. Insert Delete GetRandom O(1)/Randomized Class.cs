namespace PlacementTraining2;

public class RandomizedSet
{
    private Dictionary<int, int> numDict;
    private List<int> numList;

    public RandomizedSet()
    {
        numDict = new Dictionary<int, int>();
        numList = new List<int>();
    }

    public bool Insert(int val)
    {
        if (!numDict.ContainsKey(val))
        {
            numDict.Add(val, numList.Count);
            numList.Add(val);

            return true;
        }

        return false;
    }

    public bool Remove(int val)
    {
        if (numDict.ContainsKey(val))
        {
            int numListSize = numList.Count;
            int removedElementIndex = numDict[val];
            int lastElement = numList[numListSize - 1];

            //Swap last element with removal element
            numList[removedElementIndex] = lastElement;

            //update the last element in dictionary(numDict)
            numDict[lastElement] = removedElementIndex;

            numList.RemoveAt(numListSize - 1);
            numDict.Remove(val);

            return true;
        }

        return false;
    }

    public int GetRandom()
    {
        int randomIndex = Random.Shared.Next(numList.Count);

        int num = numList[randomIndex];

        return num;
    }
}