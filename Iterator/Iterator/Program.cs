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

// yield break;
static IEnumerable<int> CountWithTimeLimit(DateTime limit)
{
    for (int i = 0; i < 10; i++)
    {
       if (DateTime.Now >= limit)
        {
            yield break;
        }
       
         yield return i;
    }
}

// Yield break try/Finally
static IEnumerable<int> CountWithTimeLimitWithTryFinal(DateTime limit)
{
    try
    {
        for (int i = 0; i <= 10; i++)
        {
          
            if (DateTime.Now >= limit)
            {
                yield break;
            }

            yield return i;
        }
    }
    finally
    {
        Console.WriteLine("Stopping!");
    }
    
}


DateTime stop = DateTime.Now.AddSeconds(2);

foreach (int i in CountWithTimeLimitWithTryFinal(stop))
{
    Console.WriteLine("Received {0}",i);
    if (i > 3)
    {
        Console.WriteLine("Retunring");
        return;
    }
    await Task.Delay(300);//300 milisecond tương đương 6 lần lặp - thời gian càng ít số lần lặp càng 
}

IEnumerable<int> iterable1 = CountWithTimeLimitWithTryFinal(stop);
IEnumerator<int> iterator1 = iterable1.GetEnumerator();

/*while (true)
{
    bool result = iterator1.MoveNext();
 
    Console.WriteLine(result);
    Console.WriteLine("Received {0}",iterator1.Current);
    if (iterator.Current > 3)
    {
        Console.WriteLine("Retunring");
        return;
    } 
    await Task.Delay(300);
}*/
Console.WriteLine("Received {0}",iterator1.Current);
bool result1 = iterator1.MoveNext();
Console.WriteLine(result1);
Console.WriteLine("Received {0}",iterator1.Current);

iterator.MoveNext();
Console.WriteLine("Received {0}",iterator.Current);