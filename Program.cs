using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stena_of_China
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "#";
            string str10 = str + str + str + str + str + str + str + str + str + str;
            string str100 = str10 + str10 + str10 + str10 + str10 + str10 + str10 + str10 + str10 + str10;
            string str1000 = str100 + str100 + str100 + str100 + str100 + str100 + str100 + str100 + str100 + str100;
            Console.WriteLine(str1000);
        }
    }
}
