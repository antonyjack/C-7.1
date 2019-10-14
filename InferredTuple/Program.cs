using System;

namespace InferredTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "C#";
            double version = 7.1;

            //Previous version
            var detail = (name: name, version: version);
            Console.WriteLine($"Name : {detail.name} and Version : {detail.version}");

            //C# 7.1
            var detail1 = (name, version);
            Console.WriteLine($"Name : {detail1.name} and Version : {detail1.version}");
        }
    }
}
