using Extension.MD5Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Md5HasherSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World".ToMD5("this is my salt"));
            Console.ReadKey();
        }
    }
}
