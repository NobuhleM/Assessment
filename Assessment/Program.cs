using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            Utility util = new Utility();
            Console.Write("Enter text o be analysed");
            string input = Console.ReadLine();
 

            Console.WriteLine("Enter which operations to do on the supplied text," +
                " ‘1’ for a duplicate character check, ‘2’ to count the number of vowels," +
                " ‘3’ to check if there are more vowels or non vowels," +
                " or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks: ");
            string operation = Console.ReadLine();

            util.performFunction(operation, input);
            Console.WriteLine(util.performFunction(operation, input) );
            Console.ReadLine();

        }
    }
}
