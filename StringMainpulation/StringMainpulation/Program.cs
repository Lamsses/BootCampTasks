using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StringMainpulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsEndDot("Hello World!"));
            //Console.WriteLine(IsEndDot("Hello World."));


            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-GB"), true));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-GB"), false));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å", new CultureInfo("en-AU"), true));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-AU"), false));

            //Console.WriteLine(CheckEndString("xyzPQR", "PQR", new CultureInfo("en-AU"), false));

        }


        //Q1
        public static void CompareStrings(string str1, string str2)
        {
            Console.WriteLine(str1.ToLower() == str2.ToLower() || str1.ToLower() == str2.ToLower() ? true : false);
        }

        //Q2
        public static void CompareLetterInWord(string str1, string str2)
        {
            CultureInfo USA = new CultureInfo("en-US");
            CultureInfo Czech = new CultureInfo("cs-CZ");

            Console.WriteLine("For cs-CZ:{0}", (String.Compare(str1, str2, false, Czech)) == 1 ? str1 + " > " + str2 : str1 + " < " + str2);

        }

        //Q3
        public static void CompareStringsInMultipleWays(string str1, string str2)
        {
            Console.WriteLine(String.Compare(str1, str2, StringComparison.CurrentCulture) == 1 ? str1 + " Comes before " + str2 : str1 + " Comes after " + str2);
            Console.WriteLine(String.Compare(str1, str2, StringComparison.CurrentCultureIgnoreCase) == 1 ? str1 + " is the same as " + str2 : str1 + " is not the same as " + str2);
            Console.WriteLine(String.Compare(str1, str2, StringComparison.Ordinal) == 1 ? str1 + " Comes before " + str2 : str1 + " Comes after " + str2);


        }

        //Q4


        //Q5
        public static void CompareAndCompareordinals()
        {
            Console.WriteLine(String.CompareOrdinal("xyz"[1].ToString(), "XYZ"[1].ToString()) > 0 ? "xyz"[1] + " is greater than " + "XYZ"[1] : "xyz"[1] + " is less than " + "XYZ"[1]);
            Console.WriteLine(String.Compare("xyz"[1].ToString(), "XYZ"[1].ToString()) > 0 ? "xyz"[1] + " is greater than " + "XYZ"[1] : "xyz"[1] + " is less than " + "XYZ"[1]);


        }

    
    //Q6
    public static void ComparString()
    {
        string str1 = "JAVA";
        string str2 = "python";
        int result = string.CompareOrdinal(str1, str2);
        if (result < 0)
        {
            Console.WriteLine("String '{0}' is less than String '{1}'.", str1, str2);
        }
        else if (result > 0)
        {
            Console.WriteLine("String '{0}' is greater than String '{1}'.", str1, str2);
        }
        else
        {
            Console.WriteLine("Both strings are equal.");
        }
    }
    //Q7
    public static void ComparStringsobject()
    {
        List<object> strings = new List<object> { "TestClass", 123, "some text", "Some Text" };
        string input = "some text";
        foreach (object obj in strings)
        {
            string arguments = obj.GetType().Name;
            Console.WriteLine($"Bad argument: {obj} (type {arguments})");
            if (obj.GetType() == typeof(string))
            {
                string str = (string)obj;
                int result = string.Compare(input, str);
                Console.WriteLine("Comparing '{0}' with '{1}': {2}", input, str, result);
            }
        }
    }
    //Q8
    static void CompareArrays(string wizard1, string wizard2)
    {
        int result = string.Compare(wizard1, wizard2);
        Console.WriteLine($"Comparing {wizard1} with {wizard2} -> ");

        if (result == 0)
        {
            Console.WriteLine($"The strings occur in the same position in the sort order.");
        }
        else if (result < 0)
        {
            Console.WriteLine("The first string precedes the second in the sort order.");
        }
        else
        {
            Console.WriteLine("The first string follows the second in the sort order.");
        }
    }
    //9
    public static void Culture()
    {
        string[] strings = { "Å", "abcЙࠉ" };
        TextInfo gb = new CultureInfo("en-GB", false).TextInfo;
        bool endsWithTargetString = strings[1].EndsWith(strings[0]);
        bool containsTargetString = strings[1].Contains(strings[0]);
        if (containsTargetString)
        {
            Console.WriteLine($"The target string \"{strings[0]}\" was found in the string \"{strings[1]}\".");
        }
        else
        {
            Console.WriteLine($"The target string \"{strings[0]}\" was not found in the string \"{strings[1]}\".");
        }
        Console.WriteLine($"Using The English (United Kingdom) - \"{gb}\" culture\nCase sensitive: \n");
        Console.WriteLine($"The string to search ends with the target string: {endsWithTargetString}");
    }
    //Q10
    static void ConcatenateStrings()
    {
        string[] output = { "abcd", "efgh", "ijkl", "mnop" };
        Random random = new Random();
        for (int i = output.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = output[i];
            output[i] = output[j];
            output[j] = temp;
        }
        foreach (string word in output)
        {
            Console.WriteLine(word);
        }
    }
    //Q11
    static void threeStrings()
    {
        string str1 = "Don't count your chickens, ";
        string str2 = "before the eggs, ";
        string str3 = "have hatched.";
        string result = str1 + str2 + str3;
        Console.WriteLine(result);
    }
    //Q12
    public static void concatenate()
    {
        string[] words = { "hello", "welcome", "to", "C#", "Sharp", "create", "Windows", "client", "applications" };
        string concatenatedString = string.Join(" ", words);
        Console.WriteLine(concatenatedString);
        words[words.Length - 1] = "Windows";
        words[words.Length - 2] = "welcome";
        words[words.Length - 3] = "to";
        words[words.Length - 4] = "create";
        words[words.Length - 5] = "client";
        words[words.Length - 6] = "Sharp";
        words[words.Length - 7] = "C#";
        words[words.Length - 8] = "applications";
        string newConcatenatedString = string.Join(" ", words);
        Console.WriteLine(newConcatenatedString);
    }
    //Q13
    public static void familiarString()
    {
        string familiarString = "Kill two birds with one stone";
        string substring = "birds";
        bool isSubstring = familiarString.Contains(substring);
        Console.WriteLine($"'{substring}' is in the string '{familiarString}': {isSubstring}");
        if (isSubstring)
        {
            int startIndex = familiarString.IndexOf(substring);
            Console.WriteLine($"'{substring}' begins at character position {startIndex}");
        }
    }
    //Q14
    public static void copy()
    {
        string s1 = "JAVA";
        string s2 = "Python";
        Console.WriteLine("Before assignment:");
        Console.WriteLine("s1 = " + s1);
        Console.WriteLine("s2 = " + s2);
        s2 = s1;
        Console.WriteLine("\nAfter assignment using the assignment operator:");
        Console.WriteLine("s1 = " + s1);
        Console.WriteLine("s2 = " + s2);
    }




    //Q15
    static bool IsEndDot(string input)
        {
            return input.EndsWith(".");
        }

        //Q16 need to check more
        static bool CheckEndString(
            string input,
            string target,
            CultureInfo culture,
            bool isSensitive)
        {
            return input.EndsWith(target, isSensitive, culture);
        }

        //Q17 
        static string CheckParticularSubstring(
            string input,
            string target,
            CultureInfo culture,
            bool isSensitive)
        {
            return input.EndsWith(target, isSensitive, culture) ?
                $"'{input}' ends with '{target}'." :
                $"'{input}' not ends with '{target}'.";
        }

        //Q19
        static string ReverseAndUpperWords2(string input)
        {
            return string.Concat(input.Reverse()).ToUpper();
        }


        //Q20
        static string RemoveDuplicateLetters(string input)
        {
            return string.Concat(input.Distinct());
        }

        //Q21


        //Q22
        static string ReverseTheCaseForLetters(string input)
        {
            string reversedString = "";

            foreach (var letter in input)
            {
                reversedString += char.IsUpper(letter) ? char.ToLower(letter) : char.ToUpper(letter);
            }

            return reversedString;
        }


        //Q22
        public static string ReverseTheCaseForLetters2(string text)
        {
            return string.Concat(text.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
        }


        //Q23
        public static string GetCentralCharacter(string text)
        {
            int l = 1 - text.Length % 2;
            return text.Substring(text.Length / 2 - l, 1 + l);
        }

        //Q24
        public static string GetMinimumAndMaximumNumberWords(string str_num)
        {
            var result = str_num.Split(' ').Select(int.Parse).ToArray();
            return result.Max() + ", " + result.Min();
        }

        //Q25
        public static bool Isisograms(string str1)
        {
            int str_len = str1.Length;
            return str1.ToLower().Distinct().Count() == str_len;
        }

        //Q26
        public static string ConvertFirstLetterToUpper(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }

        //Q27
        public static int GetPositionWord(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }

        //Q28
        public static string CovertOddLettersInWordtoUpper(string str)
        {
            string text = str.Replace(" ", "  ");
            string result_str = "";
            result_str += Char.ToUpper(str[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) result_str += Char.ToLower(text[i]);
                else result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;
        }


        //Q29
        public static string reversWordsEvenLenght(string text)
        {
            return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
        }

        //Q30
        public static string LongesCommonEndingBetweenWords(string st1, string st2)
        {
            for (int i = 0; i < st1.Length; i++)
            {
                string end = st1.Substring(i);
                if (st2.EndsWith(end))
                {
                    return end;
                }
            }
            return "";
        }

    }

}
