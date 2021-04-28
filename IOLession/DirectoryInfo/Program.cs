using System;
using System.IO;

namespace DirectoryAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
        
            DirectoryInfo directory = new DirectoryInfo(@"C:\windows");

            if (directory.Exists)
            {
              //  DirectoryInfo[] directoryInfo = directory.GetDirectories();
                FileInfo[] fileInfo = directory.GetFiles();
                foreach (var file in fileInfo)
                {
                    Console.WriteLine(file.FullName);

                }
            }
            else
            {
                Console.WriteLine("Directory is not exists");
            }
            Console.ReadKey();
        }
    }
}
