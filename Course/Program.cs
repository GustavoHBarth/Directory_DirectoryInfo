using System;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp";

            try
            {
                //pegar todas as sub pastas
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                //pegar todos os sub arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //criar nova pasta
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
