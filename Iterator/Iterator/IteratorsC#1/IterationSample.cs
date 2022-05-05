using System.Collections;

namespace Iterator.IteratorsC_1;

public class IterationSample : IEnumerable
{
   public object[] values; 
   public int startingPoint;
    public IterationSample(object[] values,int startingPoint)
    {
        this.values = values;
        this.startingPoint = startingPoint;
    }
    public IEnumerator GetEnumerator()
    {
       return new IterationSampleIterator(this);
    }
}