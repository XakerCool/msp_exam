using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace msp_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveInfo();


            Console.ReadLine();
        }
        static void GiveInfo()
        {
            long allPCSpace = 0;
            long allFreeSpace = 0;
            List<string> drivesNames = new List<string>();
            int memoryCount = 1079741824;
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine("Name of drive: " + drive.Name);
                drivesNames.Add(drive.Name);
                Console.WriteLine(drive.Name + "'s Total Free Space: " + drive.TotalSize/memoryCount + " gb");
                allPCSpace += drive.TotalSize / memoryCount;
                Console.WriteLine(drive.Name + "'s Available Free Space: " + drive.AvailableFreeSpace/memoryCount + " gb");
                allFreeSpace += drive.AvailableFreeSpace / memoryCount;
                Console.WriteLine(drive.Name + "'s Drive Type: " + drive.DriveType);
                Console.WriteLine("-------------------------------------");
            }
            Console.Write("All PC drives names: ");
            foreach(var name in drivesNames)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"All PC drives space: {allPCSpace} gb");
            Console.WriteLine($"All FREE PC drives space: {allFreeSpace} gb");
        }
    }
}
