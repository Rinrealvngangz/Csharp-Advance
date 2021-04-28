using System;
using System.IO;

namespace BinaryReadWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePath = "test.txt";
            string strName = "rinCT";
            double number = 4.7;
            byte byteNumber = 20;

            BinaryWriter bw = new BinaryWriter(new FileStream(namePath,FileMode.OpenOrCreate, FileAccess.ReadWrite));
            try
            {
                bw.Write(strName);
                bw.Write(number);
                bw.Write(byteNumber);
            }
            catch(IOException ioe){

                Console.WriteLine(ioe.Message);
            }
            bw.Close();
            Console.WriteLine("Ghi thanh cong!");

            BinaryReader br = new BinaryReader(new FileStream(namePath, FileMode.Open, FileAccess.Read));
                            Console.WriteLine(br.ReadString());
                            Console.WriteLine(br.ReadDouble());
                            Console.WriteLine(br.ReadByte());
                            br.Close();
            Console.ReadKey();

        }
    }
}
