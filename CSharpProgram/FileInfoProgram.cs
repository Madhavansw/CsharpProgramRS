﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSharpProgram
{
    public class FileInfoProgram
    {
       static void Main()
        {

            // my code 
            string _path = Path.GetFileName("D:\\FileSystem\\Text.txt");
            FileInfo finfo = new FileInfo(_path);
            using(StreamWriter sw = finfo.CreateText())
            {
                sw.WriteLine("This c# File Programin!");
                sw.WriteLine("This c# sample Programing!");
                sw.WriteLine("This c#");
            }

           using(StreamReader sr = finfo.OpenText())
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }


            string path = Path.GetTempFileName();
            FileInfo fi1 = new FileInfo(path);
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("This is");
                sw.WriteLine("Sanfoundry");
                sw.WriteLine("Website");
            }

            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            fi1.CopyTo(_path);
            finfo.Delete();

            try
            {
                string path2 = Path.GetTempFileName();
                FileInfo fi2 = new FileInfo(path2);
                fi2.Delete();
                fi1.CopyTo(path2);
                Console.WriteLine("{0} was copied to {1}.", path, path2);
                fi2.Delete();
                Console.WriteLine("{0} was successfully deleted.", path2);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.Read();


        }
    }
}
