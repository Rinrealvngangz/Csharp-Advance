using System;
using System.Collections.Generic;


namespace ConvertAllMethod
{
    public sealed class Pair<T1,T2> : IEquatable<Pair<T1,T2>>
    {
        private  static  readonly IEqualityComparer<T1> FirstComparer =
            EqualityComparer<T1>.Default;
        
        private  static  readonly IEqualityComparer<T2> SecondComparer =
            EqualityComparer<T2>.Default;

        private readonly T1 first;
        private readonly T2 second;

        public Pair(T1 first,T2 second)
        {
            this.first = first;
            this.second = second;
        }
        
        public T1 Frist
        {
            get { return first; }
        }

        public T2 Second
        {
            get { return second; }
        }
        
        public bool Equals(Pair<T1, T2>? other)
        {
            return other != null &&
                 //  this.first == other.Frist : error
                  FirstComparer.Equals(this.first, other.Frist) &&
                   SecondComparer.Equals(this.second, other.Second);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Pair<T1, T2>);
        }

        public override int GetHashCode()
        {
           return FirstComparer.GetHashCode(first) * 37 + 
                  SecondComparer.GetHashCode(second);

        }
    }

    public static class Pair
    {
        public static Pair<T1, T2> Of<T1, T2>(T1 first, T2 second)
        {
            return new Pair<T1, T2>(first, second);
        }
    }
}