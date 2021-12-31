using System.Collections.Generic;
using System;
namespace LiminationsOfGeneric
{
    partial class ComparisonHelper<TBase,TDerived> : IComparer<TDerived> where TDerived : TBase
    {
        private readonly IComparer<TBase> _comparer;

        public ComparisonHelper(IComparer<TBase> comparer)
        {
            _comparer = comparer;
        }
         public int Compare(TDerived? x, TDerived? y)
         {
             return _comparer.Compare(x, y);
         }
     }
}