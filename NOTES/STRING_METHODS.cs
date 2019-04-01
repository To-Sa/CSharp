using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "one";
            string b = "one";
            int x = String.Compare(a, b);
            if (x == 0)
            {
                Console.WriteLine(" a == b");
            }
            else if (x < 0)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a > b");
            }


            string s = "VeryLongLongString";
            char[] chs = new char[] { 'y', 'z', 'o' };
            Console.WriteLine(s.IndexOf('r')); //index of the first occurrence > 2
            Console.WriteLine(s.IndexOfAny(chs)); // 3
            Console.WriteLine(s.LastIndexOf('n')); //index of the last occurrence > 16
            Console.WriteLine(s.LastIndexOfAny(chs)); // 9
            Console.WriteLine(s.Contains("Long")); // True


            string t = "smallstring";
            char[] chr = new char[] { 's', 'g' };
            Console.WriteLine(t.Replace('s', 'l')); // lmallltring
            Console.WriteLine(t.Trim(chr)); // mallstrin
            Console.WriteLine(t.Insert(0, "one")); // onesmallstring
            Console.WriteLine(t.Remove(0, 2)); // allstring
            Console.WriteLine(t.Substring(0, 3)); // sma
            Console.WriteLine(t.ToUpper()); // SMALLSTRING
            Console.WriteLine(t.ToLower()); // smallstring

            Console.ReadKey();
        }   
    }
}
