using Iterator.IteratorsC_1;
using Iterator.IteratorC_2;
using Iterator.IteratorWorkflow;

object [] values = {"a","b","c","d","e"};
Console.WriteLine("In in C# 1");
IterationSample iterationSample = new IterationSample(values,3);

foreach (object x in iterationSample)
{
    Console.WriteLine(x);
}

Console.WriteLine("In C# 2");
IterationSample2 iterationSample2 = new IterationSample2(values, 3);
foreach (object x in iterationSample2)
{
    Console.WriteLine(x);
}

Console.WriteLine("Iterator workflow");
IEnumerable<int> iterable =  IteratorWorkflowSample.CreateEnumerable();
IEnumerator<int> iterator = iterable.GetEnumerator();
Console.WriteLine("Starting to iterate");
while (true)
{
    Console.WriteLine("Calling MoveNext()...");
    bool result = iterator.MoveNext();//call MoveNext() thì Call mới Execute GetEnumerator()
    Console.WriteLine("... MoveNext result={0}",result);
    if (!result)
    {
        break;
    }
    Console.WriteLine("Fetching Current...");
    Console.WriteLine("... Current result={0}",iterator.Current);
}
