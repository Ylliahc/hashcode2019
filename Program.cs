using System;
using System.Text.RegularExpressions;
using hashcode2019.Data;

namespace hashcode2019
{
    class Program
    {
        private const string V = "D:\\Users\\xchailly\\Documents\\Hashcode\\2019\\d_pet_pictures.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = V;

            var reader = new InputReader(path);

            var toto = reader.Read();

            Console.WriteLine("This is the end");
        }
    }
}
