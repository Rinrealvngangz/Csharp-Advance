namespace DelegateInDepth;

public class AnonymousMethod
{
    public static  Action<string> printHello = delegate(string s)
    {
        Console.WriteLine(s);
    };
    
    public static  Action<int> printNumber = delegate(int i)
    {
        Console.WriteLine(i.ToString());
    };
    
    public static Action Notify = delegate
    {
        Console.WriteLine("Hello Word");
    };

    public static Func<int, bool> isDivideTwo = delegate(int i)
    {
        return i % 2 == 0;
    };
 
    public static void printListNumber()
    {
        List<int> x = new List<int>();
        x.Add(1);
        x.Add(2);
        x.Add(3);
       // x.ForEach(printNumber);
       x.Where(isDivideTwo).ToList().ForEach(printNumber);
    }

    public static void SortName(Comparison<string> cmp)
    {
        string[] arrStrs = new string[] {"Tuan", "Rin", "Bao", "An"};
        Array.Sort(arrStrs,cmp);
    }
    
    //Capturing variables in anonymous methods - same closures

    public static void EnClosingMethod()
    {
        int outerVariable = 5;
        string capturedVariable = "captured ";
        Console.WriteLine("Closures");
        if (DateTime.Now.Hour == 23)
        {
            int normalLocalVariable = DateTime.Now.Minute;
            Console.WriteLine(normalLocalVariable);
        }

        Action x = delegate()
        {
            string anonLocal = "local to anonymous method";
            capturedVariable = "change captured";
            Console.WriteLine(capturedVariable + anonLocal);
        };
        x();
        Console.WriteLine(capturedVariable);
        
    }
   // Extended lifetime of capture variable 
    public static Action CreatDelegateInstance()
    {
        int counter = 5;
        Action ret = delegate
        {
            Console.WriteLine(counter);
            counter++;
        };
        ret();
        return ret;
    }
    //Capture multiple variable instantiations with multiple delegates
    public static void MultiDelegates()
    {
        List<Action> list = new List<Action>();
        for (int index = 0; index < 5; index++)
        {
            int counter = index * 10;
            list.Add(delegate { 
                Console.WriteLine(counter);
                counter++;
            });
        }

        foreach (var t in list)
        {
            t();
        }

        list[0]();
        list[0]();
        list[0]();
        list[1]();
    }
}