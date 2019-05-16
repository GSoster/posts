using System.Collections.Generic;

namespace YieldKeyword
{
    public static class FilterCollection
    {
        public static IEnumerable<int> CollectionOneToTen()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
        }

        public static IEnumerable<int> CollectionOneToTenLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }

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