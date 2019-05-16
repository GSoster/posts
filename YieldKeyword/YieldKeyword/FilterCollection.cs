using System.Collections.Generic;

namespace YieldKeyword
{
    public static class FilterCollection
    {
        public static IEnumerable<int> FilterNumbersGreaterThan(List<int> collection, int max)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] > max)
                    yield return collection[i];
            }
        }
    }
}