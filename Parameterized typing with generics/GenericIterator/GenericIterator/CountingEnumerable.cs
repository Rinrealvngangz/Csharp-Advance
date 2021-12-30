using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericIterator
{
    public class CountingEnumerable : IEnumerable<int>
    {
        private readonly List<int> _list;
        public CountingEnumerable(List<int> list)
        {
            _list = list;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator(_list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}