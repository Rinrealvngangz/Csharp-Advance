using Iterator.IteratorsC_1;
using Iterator.IteratorC_2;

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

