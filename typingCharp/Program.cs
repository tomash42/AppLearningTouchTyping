//High - fix backspace char = 8

using System;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace typingCharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LVL 1 - Left Hand A S D F");
            Console.WriteLine("LVL 2 - Right Hand J K L ;");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your Choice is : ");
            var menuNr = Convert.ToSByte(Console.ReadLine());
            Console.ResetColor();
            do
            {
               //menu
                switch (menuNr)
                {
                    case 1:
                        lelftHand();
                        break;
                    case 2:
                        rightHand();
                        break;
                    default:
                        Console.WriteLine("App is under construction");
                        Console.WriteLine("Select again ");
                        menuNr = Convert.ToSByte(Console.ReadLine());
                        break;
                }
                //exit
                Console.WriteLine("Exit : y  or n ");
                cki = Console.ReadKey(true);
            } while (cki.KeyChar!=(char)'y');


        }

        private static void lelftHand()
        {

            //variables
            int sum = 0, good = 0, bad = 0, totalChar, numberSentence;
            string[] sentence = new string[3];
            //Timer
            Stopwatch timeApp = new Stopwatch();
            //array with sentence and RANDOM
            sentence[0] = "aaaa ssss dddd ffff asds ssdd aasd ffdd";
            sentence[1] = "dfff fffa afsd dsdf sasf sfas ssss ffff";
            sentence[2] = "fafa fsfs fdfd dafa saaf sffa aasf dsaa";
            Random rd = new Random();
            numberSentence = rd.Next(0, sentence.Length);
            //sb 
            StringBuilder sb = new StringBuilder();
            sb.Append(sentence[numberSentence]);
            Console.WriteLine(sb);
            //Console 
            ConsoleKeyInfo cki;
            //mian loop 

            do
            {
                timeApp.Start();
                cki = Console.ReadKey(true);
                if (cki.KeyChar == sb[sum])
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(cki.KeyChar);
                    Console.ResetColor();
                    good++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(cki.KeyChar);
                    Console.ResetColor();
                    bad++;
                }
                timeApp.Stop();
                sum++;

            } while (sum != sb.Length);
      
            totalChar = sb.Length;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\nYour time is : {0}", timeApp.Elapsed);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total char is : {0}", totalChar);
            Console.WriteLine("Good : {0} Bad :  {1}", good, bad);
            Console.ResetColor();
              }
        private static void rightHand()
        {

            //variables
            int sum = 0, good = 0, bad = 0, totalChar, numberSentence;
            string[] sentence = new string[3];
            //Timer
            Stopwatch timeApp = new Stopwatch();
            //array with sentence and RANDOM
            sentence[0] = "jjjj kkkk llll ;;;; kjkj klkl l;l; ;l;l";
            sentence[1] = "jlk; ;klj lklk ;j;j l;jk klj; ljlj ;;jj";
            sentence[2] = "jkl; llj; lkk; l;l; l;;l ;;jj lj;; ;jjl";
            Random rd = new Random();
            numberSentence = rd.Next(0, sentence.Length);
            //sb 
            StringBuilder sb = new StringBuilder();
            sb.Append(sentence[numberSentence]);
            Console.WriteLine(sb);
            //Console 
            ConsoleKeyInfo cki;
            //mian loop 

            do
            {
                timeApp.Start();
                cki = Console.ReadKey(true);
                if (cki.KeyChar == sb[sum])
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(cki.KeyChar);
                    Console.ResetColor();
                    good++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(cki.KeyChar);
                    Console.ResetColor();
                    bad++;
                }
                timeApp.Stop();
                sum++;

            } while (sum != sb.Length);

            totalChar = sb.Length;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\nYour time is : {0}", timeApp.Elapsed);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total char is : {0}", totalChar);
            Console.WriteLine("Good : {0} Bad :  {1}", good, bad);
            Console.ResetColor();
        }

    }
}
