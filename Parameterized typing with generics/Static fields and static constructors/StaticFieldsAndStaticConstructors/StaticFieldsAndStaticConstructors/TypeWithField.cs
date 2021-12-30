using System;

namespace StaticFieldsAndStaticConstructor
{
    public class TypeWithField<T>
    {
        public static string field;

        public static void PrintFields()
        {
            Console.WriteLine(field + ":" +  typeof(T).Name);
        }
    }
}