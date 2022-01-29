using System;

namespace ParamOut_Ref_Val
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String value:");
            string inputString = Console.ReadLine();
            //Creating variables before passing it in function
            //Assigning value to Ref variable before passing it in function
            int _out, _ref = 0;
            CountOutparams(inputString, out _out);
            CountRefparams(inputString, ref _ref);
            Console.ReadLine();
        }

        public static int CountOutparams(string strString, out int wordCount)
        {
            string[] input = strString.Split(" ");
            //Assing values to Out params before control leaves the current method
            wordCount = input.Length;
            return strString.Length;
        }
        public static int CountRefparams(string strString, ref int wordCount)
        {
            string[] input = strString.Split(" ");
            //Assing values to Ref params before control leaves the current method.
            //no error if we didn't assing value for ref variables
            wordCount = input.Length;
            return strString.Length;
        }

    }
}
