using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.StringStudy
{
    class ReverseEachWordOfSentence
    {
        /*string str;
        public string ReverseString(string st4r)
        {   
            string  result = " ";
            if (string.IsNullOrEmpty(str))
                return string.Empty;
         
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result = result + str[i];

            }
            Console.WriteLine("reverse string is : " + result);

            return result;
        }*/
        /*static void Main(string[] args)
        {
            ReverseEachWordOfSentence r = new ReverseEachWordOfSentence();
            string result = string.Empty;
            Console.WriteLine("Enter the string");

            string str = Console.ReadLine();
            string[] arr = str.Split();
            for(int i=0; i<=arr.Length; i++)
            {
                if( i == arr.Length-1)
                {
                    result = result + r.ReverseString(arr[i]);
                }
                else
                {
                    result = result + r.ReverseString(arr[i]) + " ";
                }
            }
        }*/
    }
}
