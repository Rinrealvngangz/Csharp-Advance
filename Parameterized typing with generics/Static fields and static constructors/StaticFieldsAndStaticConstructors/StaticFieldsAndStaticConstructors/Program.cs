using System;
namespace StaticFieldsAndStaticConstructor
{
    class Program 
    {
        static void Main(string[] args)
        {
           /* TypeWithField<int>.field = "Firsts";
            TypeWithField<int>.PrintFields();
            
            TypeWithField<string>.field = "Second";
            TypeWithField<string>.PrintFields();

            TypeWithField<DateTime>.field = "Third"; 
            TypeWithField<DateTime>.PrintFields();*/
           Outer<int>.Inner<string,DateTime>.DummyMethod();
           
           Outer<int>.Inner<string,DateTime>.DummyMethod();
        }
    }
}