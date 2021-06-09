using System;

namespace Fibonnacci {
    class Program {
        private static void Main() {
            bool wiederholung = false; ;
            ulong first = 0, second = 1, next; //deckt Zahlen von 0 bis 1,8*10^19 ab
            short k = 0;
            string eingabe;
            Console.ForegroundColor = ConsoleColor.White;
            do {
                try {
                    Console.Write("{{0}Bitte geben sie die Anzahl an Fibonnacci-Folgen ein:", Environment.NewLine);
                    k = Convert.ToInt16(Console.ReadLine());
                } catch (FormatException er) {
                    Console.WriteLine(er.Message);
                }
                if (k < 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR!Repeat ur input,please!{0}", Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                } else if (k == 1)
                    Console.Write("Die erste Fibonnaci-Folge lautet:1");
                else if (k == 2)
                    Console.Write("Die ersten beiden Fibonnacci-Folgen lauten:1 und 2");
                else {
                    Console.Write("Die ersten {0} Fibonacci-Folgen lauten:{1}", k, Environment.NewLine);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    //Algorithmus zur Bestimmung aller Fibonacci-Zahlen von 1 bis k 
                    for (int j = 1; j <= k; j++) {
                        next = first + second;
                        first = second;
                        second = next;
                        if (j == k) Console.Write(next);
                        else Console.Write(next + ",");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write("{0}", Environment.NewLine);
                do {
                    Console.Write("Nocheinmal?(J)a/(N)ein:");
                    eingabe = Console.ReadLine();
                } while (!String.Equals(eingabe.ToUpper(), "J") && !String.Equals(eingabe.ToUpper(), "N"));
                if (String.Equals(eingabe.ToUpper(), "J")) {
                    wiederholung = true;
                    first = 0; second = 1;
                } else
                    wiederholung = false;
            } while (wiederholung);
        }
    }
}
