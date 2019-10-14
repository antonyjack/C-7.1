using System;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        
        static async Task<int> Main(string[] args) => await Display();        

        static async Task<int> Display()
        {
            Console.WriteLine("Hello World");            
            return await Task.FromResult(1);
        }        

        /*
        static int Main(string[] args)
            => Display().GetAwaiter().GetResult();

        static async Task<int> Display()
        {
            Console.WriteLine("Hello World");
            return await Task.FromResult(1);
        }
        */
    }
}
