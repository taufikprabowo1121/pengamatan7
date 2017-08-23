using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Pengamatan7
{
    class Program
    {
       private async void Salin()
        {
            string StartDirectory = @"d:\start";
            string EndDirectory = @"d:\end";
            foreach (string filename in Directory.EnumerateFiles(StartDirectory))
            {
                Console.WriteLine("Out Hasil :" + filename);
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(EndDirectory + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        
                    }
                }
            }
           
        }
        static void Main(string[] args)
        {
            Program b = new Program();
            b.Salin();
            Console.ReadKey();

        }
    }
}
