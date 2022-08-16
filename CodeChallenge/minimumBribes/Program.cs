// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] bQueue = {8,1,2,7,3,5,4,6};
Solution.minimumBribes(bQueue);
public class Solution
{

    public static void minimumBribes(int[] bribedQueue)
    {
        var normalQueue = bribedQueue.ToList();
        int bribesCount = 0;
        normalQueue.Sort();
        var dictionaryOfPositionAndBribes = new Dictionary<int,int>();
        for(int i = 0; i <= normalQueue.Count -1 ; i++)
        {
            if(normalQueue[i] != bribedQueue[i])
            {
                int iNormalPosition = normalQueue.IndexOf(bribedQueue[i]) + 1;
                int bribesToNewPosition = iNormalPosition - (bribedQueue.ToList().IndexOf(bribedQueue[i]) + 1);
                if(bribesToNewPosition <= 0) {continue;}
                dictionaryOfPositionAndBribes.Add(bribedQueue[i],bribesToNewPosition);
                bribesCount++;
            }
        }
        if(dictionaryOfPositionAndBribes.Values.Any(x => x > 2))
        {
            Console.WriteLine("Too Chaotic");
        }
        else
        {
            Console.WriteLine(bribesCount);
        }
    }
}