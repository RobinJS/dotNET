using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3Dspace
{
    public static class PathStorage
    {
        static void SavePath(string fileAddress, string pathToSave)
        {
            File.AppendAllText(fileAddress, pathToSave);
        }

        static string GetPath(string fileAddress)
        {
            using (StreamReader sr = new StreamReader(fileAddress))
            {
                return sr.ReadLine();
            }
        }
    }
}
