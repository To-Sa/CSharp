using System;
using System.Text.RegularExpressions;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("^[1-9][0-9]*");
            string s1 = "-12345";
            string s2 = "112345";
            string s3 = "2";
            Console.WriteLine("{0} : {1}", s1, (pattern.IsMatch(s1) ?
            "natural numbers" : "not natural numbers"));
            Console.WriteLine("{0} : {1}", s2, (pattern.IsMatch(s2) ?
            "natural numbers" : "not natural numbers"));
            Console.WriteLine("{0} : {1}", s3, (pattern.IsMatch(s3) ?
            "natural numbers" : "not natural numbers"));
            // ^[1-9]: Start at the beginning of the string.
            // [0-9]*: Match [0-9] characters.


            //Telephone number checking: +36 30 123-456-789
            string s = @"^(\+)[1-9][0-9]{1,2}\s[1-9][0-9]{1,2}\s(\d{3}(-)){2}\d{3}$";
            Regex patternTelephone = new Regex(s);
            string t1 = "+36 30 661-345-612";
            string t2 = "+3630 661-567-233";
            string t3 = "+56 30 667-876-987-456";
            Console.WriteLine(patternTelephone.IsMatch(t1)); // true
            Console.WriteLine(patternTelephone.IsMatch(t2)); // false
            Console.WriteLine(patternTelephone.IsMatch(t3)); // false

            Console.ReadKey();
        }   
    }
}
