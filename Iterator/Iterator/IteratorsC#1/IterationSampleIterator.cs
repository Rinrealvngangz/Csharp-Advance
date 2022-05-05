using System.Collections;

namespace Iterator.IteratorsC_1;

public class IterationSampleIterator : IEnumerator
{
    private IterationSample _iterationSample;
    private int position;
    public IterationSampleIterator(IterationSample iterationSample)
    {
        _iterationSample = iterationSample;
        position = -1;
    }
    public bool MoveNext()
    {
        if (position != _iterationSample.values.Length)
        {
            position++;
        }

        return position < _iterationSample.values.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get
        {
            if (position == -1 ||
                position == _iterationSample.values.Length)
            {
                throw new InvalidOperationException();
            }

            int index = position + _iterationSample.startingPoint;
            index = index % _iterationSample.values.Length;
            return _iterationSample.values[index];
        }
    }
}