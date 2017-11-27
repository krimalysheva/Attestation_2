using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogic
{
    public class FileUtils
    {
        public static string ReadStringFromFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteStringToFile(string path, string str)
        {
            File.WriteAllLines(path, new string[] { str });
        }
    }
}
