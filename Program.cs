using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            int seconds = 0;
            Console.Clear();
            Console.WriteLine("Inform the time to count");
            Console.WriteLine("S = Seconds (Ex: 10s)");
            Console.WriteLine("M = Minute (Ex: 10m)"); 
            Console.WriteLine("X  = Sair");
            Console.Write(">");
            string? data = Console.ReadLine().ToLower();
            char type =  char.Parse(data.Substring(data.Length-1,1));
            if(data.Length >= 2){
            seconds = Convert.ToInt32(data.Substring(0, data.Length-1));
            }
            
            switch(type){
                case 's': PreStart(seconds); break;
                case 'm': seconds = seconds * 60; PreStart(seconds); break;
                case 'x': System.Environment.Exit(0);break;
                default : Menu(); break;
            }
            
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("START!");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {   
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finished");
            Thread.Sleep(2500);
        }
    }
}