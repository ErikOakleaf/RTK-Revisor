using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RTK_Revisor
{
    public static class TextConnectionProcessor
    {
        public static string GetPath(string folder, string file)
        {

            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (!directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return Path.Combine(directory.ToString(), folder, file);
        }
        public static string[] LoadFile(this string path)
        {
            if (!File.Exists(path))
            {
                return new string[0];
            }
            else
            {
                return File.ReadAllLines(path);
            }
        }
    }
}
