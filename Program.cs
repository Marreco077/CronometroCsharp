﻿namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args) {
           Menu();
        }

        static void PreStart(int time) {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = data[^1];
            int time = int.Parse(data[..^1]);
            int multiplier = 1;
            
            if(type == 'm') {
                multiplier = 60;
            }
            if(time == 0) {
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
        }

        static void Start(int time) {

            int currentTime = 0;

            while(currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Menu();
        }
    }
}