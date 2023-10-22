using System;
using System.ComponentModel.Design;

namespace inlamning3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är din låt?");
            string answer = Console.ReadLine();
            int space = answer.IndexOf(" ");
            int min = int.Parse(answer[..space]);
            int sec = int.Parse(answer[(space +1)..]);
            int totalLength = (min * 60) + sec;

            if (totalLength >= 165 && totalLength <= 260)
                Console.WriteLine("Låten får spelas");

            else
                Console.WriteLine("Låten får inte spelas");



        }

    }

}
