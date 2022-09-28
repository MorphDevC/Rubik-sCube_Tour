using System.Collections.Generic;
using System.Linq;

public static class ListExt
{
    public static List<T> GetListExpectValue<T>(this List<T> targetList, T targetValue)
    {
        List<T> kek = new List<T>(targetList);
        kek.Remove(targetValue);
        return kek;
    }
}
