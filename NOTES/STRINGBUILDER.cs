using System;
using System.Text;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The default capacity of a StringBuilder object is 16 characters,
             *and its default maximum capacity is Int32.MaxValue.*/

            StringBuilder sb = new StringBuilder(50);
            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                sb.Append(ch);
            }
            Console.WriteLine(sb);

            sb.Append(new char[] { 'D', 'E', 'F' });
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Insert(0, "Alphabet: ");
            sb.Replace('k', 'K');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            Console.ReadKey();
        }   
    }
}
