using UnityEngine;

namespace Assets.Scripts
{
    static class Utils
    {
        public static int GetRandomIndexFromWeights<T>(T[] weighted) where T : HasWeight
        {
            int count = 0;
            (int min, int max)[] ranges = new(int, int)[weighted.Length];
            for(int i = 0; i < weighted.Length; ++i)
            {
                ranges[i].min = count;
                count += weighted[i].weight;
                ranges[i].max = count - 1;
            }
            int score = Random.Range(0, count);
            for(int i = 0; i < ranges.Length; ++i)
            {
                if (ranges[i].min <= score && ranges[i].max >= score)
                {
                    return i;
                }
            }
            return -1;
        }
        public static T GetRandomFromWeight<T>(T[] weighted) where T : HasWeight
        {
            return weighted[GetRandomIndexFromWeights(weighted)];
        }
    }
    interface HasWeight
    {
        public int weight { get; set; }
    }
    interface HoldsWeighted<T> where T : HasWeight
    {
        public T[] GetWeighted();
    }
}