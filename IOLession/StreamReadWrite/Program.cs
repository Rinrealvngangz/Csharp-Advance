using System;
using System.IO;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePath = "data.txt";
            Console.Write("Nhap ten cua ban:");
            string name = Console.ReadLine();
            using(StreamWriter sw =new StreamWriter(namePath,true))
            {
                sw.WriteLine(name);
            }
            Console.WriteLine("Save file thanh cong ,Ban co muon xem doc file ?(Y/N)");
            string choice = Console.ReadLine();

            if ("Y".Equals(choice))
            {
                using(StreamReader sr =new StreamReader(namePath))
                {
                    string data = string.Empty;
                     while((data =sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);

                    }
                }
                Console.ReadKey();
            }

        }
    }
}
