using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace SaveAtFile
{


    class Program
    {
        private static void WriteFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                WriteLine("Enter the data:");
                string data = ReadLine();
                //переводим строку в байты, потоки работают только с байтами
                byte[] bytes = Encoding.UTF8.GetBytes(data);

                stream.Write(bytes, 0, bytes.Length);
                WriteLine("Data recorded");
            }

                
        }
        private static string ReadFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return Encoding.UTF8.GetString(bytes);

            }
        }
        private static void WritePileTXT(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter str = new StreamWriter(stream, Encoding.UTF8))
                {

                    WriteLine($"Start record:");
                    string data = ReadLine();
                    str.WriteLine(data);
                    foreach(var item in data)
                    {
                        str.Write($"{item}");
                    }
                }
            }

        }
        private static string WriteLineTXT(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    
                    return reader.ReadToEnd();
                }
            }
        }
        private static void WriteFileTXT(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Unicode))
                {
                    WriteLine("Enter the data:");
                    string data = ReadLine();
                    double pi = 3.14159;
                    int number = 1256;

                    writer.Write(data);
                    writer.Write(pi);
                    writer.Write(number);
                }
                WriteLine("\nData recording!");
            }
        }
        private static string ReaderBinFile(string filePath)
        {

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream, Encoding.Unicode))
                {
                    return $"{reader.ReadString()}\n{reader.ReadDouble()}\n{reader.ReadInt32()}";

                }
            }
        }
        static void Main(string[] args)
        {/*
            //string filePath = "test.bin";
            //запись данных в бинарный файл 
            //WriteFile(filePath);

            //чтение из бинарного файла 
            //WriteLine($"Data read from the file {ReadFile(filePath)}");

            try
            {
                //запись в текстовый файл
                //string filePath = "tet.txt";

                //WritePileTXT(filePath);
                // WriteLine($"Data read from the file {WriteLineTXT(filePath)}");

                //string filePath = "test.asd";
               // WriteFileTXT(filePath);
               // WriteLine($"Data read from the file {ReaderBinFile(filePath)}");


            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadLine();
            */
            DirectoryInfo directoryInfo = new DirectoryInfo(".");//если точка, это эта текущая папка 
            //DirectoryInfo directoryInfo = new DirectoryInfo("../../../../");// таким образом мы поднимаемся на папки  выше 
            WriteLine($"Full name: {directoryInfo.FullName}");
            WriteLine($"Time of creation:{directoryInfo.CreationTime}");
            FileInfo[] files = directoryInfo.GetFiles();
            foreach(FileInfo item in files)
            {
                WriteLine(item.Name);//получим список всех файлов что содержится в папке. 
            }

        }

       
    }
}
