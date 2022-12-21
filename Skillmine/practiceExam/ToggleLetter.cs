using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class ToggleLetter
    {
        static void toggleChars(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    str[i] = (char)(str[i] + 'a' - 'A');
                else if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = (char)(str[i] + 'A' - 'a');
            }
        }

        // Driver code
       /* public static void Main(String[] args)
        {
            char[] str = "PranitChougule".ToCharArray();
            toggleChars(str);
            Console.WriteLine("String after toggle ");
            Console.WriteLine(String.Join("", str));
        }*/
    }
}
