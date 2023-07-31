using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class ReplaceString
    {
        public void StringReplace()
        {
            string line = "Hello <<name>> , We ";
            Console.WriteLine("Enter full name");
            string fullName = Console.ReadLine();
            line = line.Replace("<< full name >>", fullName);
            Console.WriteLine("Enter phone number");
            string number = Console.ReadLine();
            line = line.Replace("xxxxxxxxxxx", number);
            Console.WriteLine("Final result", line);

        }
    }
}
