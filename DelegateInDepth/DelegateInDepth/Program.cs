namespace DelegateInDepth
{
    class Program 
    {
        static void Main(string[] args)
        {
            Covariance.LogData();
            AnonymousMethod.Notify();
            AnonymousMethod.printHello("Hello delegate");
            AnonymousMethod.printNumber(12);
            AnonymousMethod.printListNumber();
            AnonymousMethod.SortName(delegate(string a, string b) { return a.CompareTo(b);});
            AnonymousMethod.EnClosingMethod();
            var x  =  AnonymousMethod.CreatDelegateInstance();
            x();
            x();
            
            AnonymousMethod.MultiDelegates();
        }
    }
}

