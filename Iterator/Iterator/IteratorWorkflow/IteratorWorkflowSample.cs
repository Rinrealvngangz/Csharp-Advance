
namespace Iterator.IteratorWorkflow;

public static  class IteratorWorkflowSample
{ 
    private static readonly string padding = new string(' ',30);
    
    public static IEnumerable<int> CreateEnumerable()
    {
        Console.WriteLine("{0}Start of CreateEnumerable()",padding);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}About to yield {1}",padding,i);
            yield return i;
            Console.WriteLine("{0}After yield",padding);
        }
        Console.WriteLine("{0}Yielding final value",padding);
        yield return -1;
        Console.WriteLine("{0} End of CreateEnumerable()",padding);
    }  
}