using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class BinaryReaderProgram
    {

        const string fileName = "program.dat";
        public static void Write()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName,
                                                           FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"C:\Temp");
            }
        }

        public static void Display()
        {
            float aspectRatio;
            string tempDirectory;
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName,
                                                                 FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                }
                Console.WriteLine("Aspect Ratio Set to : " + aspectRatio);
                Console.WriteLine("Temp Directory is : " + tempDirectory);
                Console.Read();
            }
        }
        static void Main( string[] args)
        {
            Write();
            Console.WriteLine("Using Binary Writer Class the Contents are Written ");
            Display();

        }
      


        
    }
}
