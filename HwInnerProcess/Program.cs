using System;
using System.Diagnostics;

namespace HwInnerProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nWhat is your name? ");
            //var name = Console.ReadLine();
            //var date = DateTime.Now;
            //Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            //Console.Write("\nPress any key to exit...");
            //Console.ReadKey(true);

            Console.WriteLine("Program 101");
            if (args.Length !== 0)
            {
                Console.WriteLine("There is no argument");
                return ;
            }
            for (int i = 0; i < args.Length; i++)
            {
                doArgument(args[i]);
            }
        }

        static void doArgument(string args)
        {
            if (args == "--help")
            {
                Console.WriteLine("This is all function in My program");
                Console.WriteLine(
                    "(1) P101. . . . . . . .Open Picture \n" +
                    "(2) V101. . . . . . . .Open  Video \n" +
                    "(3) T101 . . . . . .  .Open  Text \n" +
                    "(4) All . . . . . .  .Open  All file \n" +
                    "(5) Q. . . . . . . . . Exit from program \n");
            }
            else if (args == "P101")
            {
                Process Picture = new Process();
                Picture.StartInfo.FileName = "C:\\Users\\win10\\Pictures\\test\\m.jpg";
                Picture.Start();
            }
            else if (args == "V101")
            {
                Process.Start("C:\\Users\\win10\\Videos\\MVI_3207.MP4");
            }
            else if (args == "T101")
            {
                Process.Start("C:\\Users\\win10\\Desktop\\Javatest.txt");
            }
            else if (args == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("There is no this type argument");
            }
        }
    }
}
