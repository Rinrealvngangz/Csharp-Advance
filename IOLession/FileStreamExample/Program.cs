using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("test.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);

            Console.WriteLine("Bat dau ghi");
            for (int i=1; i <= 20; i++)
            {
                fileStream.WriteByte((byte)i);
              
            }
            Console.WriteLine("Ghi file thanh cong");
            fileStream.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
               Console.Write(fileStream.ReadByte() + "\t");        
            }
            fileStream.Close();
            Console.WriteLine("Doc file thanh cong");
            Console.ReadKey();

        }
    }
}
