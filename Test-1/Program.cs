
using System;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Error();
        }
        static void Error()
        {
            throw new Exception("Bu bir errordur");
        }
    }
}
