using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Helper
{

    public static class App
    {
        public static string GetApplicationPath() { return Application.StartupPath; }

        public static void YesNoDialog(string text, string title, Action yesAction=null, Action noAction=null)
        {
            DialogResult dialogResult = MessageBox.Show(text, title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (yesAction == null)
                    return;

                yesAction();
            }
            else if (dialogResult == DialogResult.No)
            {
                if (noAction == null)
                    return;

                noAction();
            }
        }

    }


    public static class Files
    {

        public static class Reader
        {
            public static string ReadAllTextFile(string path)
            {
                return File.ReadAllText(path);
            }

            public static List<string> ReadLinesList(string path)
            {
                List<string> lines = new List<string>();
                StreamReader sr = new StreamReader(path);

                string line = "";
                while ((line = sr.ReadLine()) != null)
                    lines.Add(line);

                sr.Close();

                return lines;
            }

            public static string GetStringRandLine(string path)
            {
                var lines = ReadLinesList(path);

                return lines[new Random().Next(0, lines.Count)];
            }

            public static string ReadLine(string path, int index)
            {
                string text = "";

                StreamReader sr = new StreamReader(path);

                int contor = 0;
                while ((text = sr.ReadLine()) != null)
                {
                    if (contor == index)
                        return text;

                    contor++;
                }

                sr.Close();

                return null;
            }

            public static bool FileExists(string path)
            {
                return File.Exists(path);
            }

            public static bool IsEmpty(string path)
            {
                return ReadAllTextFile(path).Length == 0;
            }
        }


        public static class Writer
        {
            public static void Write(string path, string text)
            {
                File.WriteAllText(path, text);
            }
        }

    }

    public static class Strings
    {
        public static string[] CreateEmptyArray(int size, char defaultChar = '-')
        {
            // Create and return an empty array of specificied size 
            // Each element of array will be initialized with a default value specified by the user
            // If there is no default value set by user default value will be char '-'

            string[] newArr = new string[size];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = defaultChar.ToString();
            }

            return newArr;
        }

        public static int Compare(string a, string b)
        {
            // Returns -1 if lenghts are same, 0 if length of a is greater than length of b
            // and 1 if length of b is greater than length of a

            if (a.Length == b.Length) return -1;

            return (a.Length > b.Length ? 0 : 1);
        }

        public static string StrCompare(string a, string b)
        {
            // This method may be used to get the longer string 
            // You must be sure that strings are not equal
            // If strings are equals empty string will be returned

            if (a.Length == b.Length) return "";

            return (a.Length > b.Length ? a : b);
        }

        public static string RemoveSpaces(string x)
        {
            string newStr = "";

            foreach(char c in x)
            {
                if (c != ' ')
                    newStr += c;
            }

            return newStr;
        }
    }

}