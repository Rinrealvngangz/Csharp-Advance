namespace Iterator.WhereMethod;

public static class LinqWhereMethod
{
   
    public static IEnumerable<T> Where<T>(IEnumerable<T> source,
                                          Predicate<T> predicate)
    {
        if (source == null || predicate == null )
        {
            throw new ArgumentException();
        }

        return WhereImpl(source, predicate);
    }
   private static IEnumerable<T> WhereImpl<T>(IEnumerable<T> source,
                                             Predicate<T> predicate)
   {
       foreach (T item in source)
       {
           if (predicate(item))
           {
               yield return item; 
           }
       }
   }
}