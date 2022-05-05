using System.Collections;

namespace Iterator.IteratorC_2;

public class IterationSample2 : IEnumerable
{
    private object[] values;
    private int startingPoint;

    public IterationSample2(object[] values,int startingPoint)
    {
        this.values = values;
        this.startingPoint = startingPoint;
    }
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < this.values.Length; i++)
        { 
            yield return values[(i + startingPoint) % this.values.Length];
        } 
    }
}