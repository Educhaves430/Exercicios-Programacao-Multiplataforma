using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace WPFApp6
{
//    public delegate void MethodWithouArgs();
    public class ModelFile
    {

        public string Content;

        public event MethodWithouArgs ReadingFinished;
        public event MethodWithouArgs WrittingFinished;

        public void ReadFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            if (sr != null)
            {
                Content = sr.ReadToEnd();
                sr.Close();
                if (ReadingFinished != null)
                    ReadingFinished();
            }
        }

        public void WriteFile(string file, string text)
        {
            StreamWriter sw = new StreamWriter(file);
            if (sw != null)
            {
                Content = text;
                sw.Write(Content);
                sw.Close();
                if (WrittingFinished != null)
                    WrittingFinished();
            }
        }
    }
}
