using System;
using System.IO;
using System.Text;

namespace DemoBinaryReader  
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa doc va ghi binary file trong C#");
            Console.WriteLine("---------------------------------------------");

            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "Doc ghi binary file";

            //tao file co ten la mydata
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Khong the tao file.");
                return;
            }

            //ghi du lieu vao file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Khong the ghi du lieu vao file.");
                return;
            }
            bw.Close();

            //doc file
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Khong the mo file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Du lieu int: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Du lieu double: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Du lieu boolean: {0}", b);
                s = br.ReadString();
                Console.WriteLine("Du lieu string: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Khong the doc file.");
                return;
            }
            br.Close();

            Console.ReadKey();
        }
    }
}
