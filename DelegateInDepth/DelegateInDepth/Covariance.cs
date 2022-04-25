using System.Transactions;

namespace DelegateInDepth;

public class Covariance
{
    delegate Stream StreamFactory();
    static MemoryStream GenerateSampleData()
    {
        byte[] buffer = new byte[16];
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (byte)i;
        }
        return new MemoryStream(buffer);
    }
   static  StreamFactory factory = new StreamFactory(GenerateSampleData);

    static public void LogData()
    {
        using (Stream stream = factory())
        {
            int data;
            while ((data = stream.ReadByte()) != -1)
            {
                Console.WriteLine(data);
            }
        }
    }
}