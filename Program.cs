using System;
using System.Text.RegularExpressions;
using hashcode2019.Data;

namespace hashcode2019
{
    class Program
    {
        private const string V = "D:\\Hashcode\\2019\\d_pet_pictures.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                string path = V;
                var reader = new InputReader(path);
                var slideImages = reader.Read();

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("This is the end");
        }
    }
}
