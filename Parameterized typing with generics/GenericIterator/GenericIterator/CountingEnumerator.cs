using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericIterator
{
    public class CountingEnumerator : IEnumerator<int>
    {
        private readonly List<int> _list ;
        
        private int current;
        public CountingEnumerator(List<int> list)
        {
            _list = list;
            current = _list.Count;
        }
        public bool MoveNext()
        {
            current--;
            return current > -1;
        }

        public void Reset()
        {
            current = _list.Count;
        }

        public int Current
        {
            get { return _list[current]; }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Reset();
        }
    }
}