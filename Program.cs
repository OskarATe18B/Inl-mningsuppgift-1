using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            //generate a random number between 1-100
            Random random = new Random();
            int ranNum = random.Next(1, 100);
            Console.WriteLine(ranNum);
            
        }
    }
}
