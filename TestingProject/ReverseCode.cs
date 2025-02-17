using System;
using System.Collections.Generic;
using System.Text;

namespace TestingProject
{
    public class ReverseCode
    {
        public string ReverseString(string name)
        {
            char[] arr = name.ToCharArray();
            string result = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result += arr[i];
            }

            return result;
        }
    }
}
