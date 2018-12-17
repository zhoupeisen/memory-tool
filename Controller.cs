using System;
using System.Collections.Generic;

namespace project
{
    class Controller
    {
        static void Main(string[] args)
        {
            string txt, txt2;
            bool keep = true;
            int x = 0, count = 1;

            Console.WriteLine("tell me how many things you'd like practice remembering (q to quit console):");
            txt = Console.ReadLine();

            try
            {
                x = Int32.Parse(txt);
                List<Memory> mems = new List<Memory>();
                for(int i = x; x>0; x--)
                {
                    Console.Write("enter memory " + count + ": ");
                    txt = Console.ReadLine();
                    txt = txt.Trim();
                    if(txt.Equals("q"))
                    {
                        quit(txt);
                    }
                    mems.Add(new Memory(txt));
                    count++;
                }
                x = 0;
                count = 0;
                Console.Clear();
                while(keep)
                {
                    foreach (Memory mem in mems)
                    {
                        txt = mem.getMemory();
                        x++;
                        Console.WriteLine("memory " + x + ":");
                        txt2 = Console.ReadLine();
                        txt2 = txt2.Trim();
                        if(txt2.Equals("q"))
                        {
                            quit(txt2);
                        }
                        if(txt2.Equals(txt))
                        {
                            Console.WriteLine("right!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine(txt2 + " != " + txt);
                        }
                    }
                    Console.WriteLine("You got " + count + " right!");
                    Console.WriteLine("enter 'r' to repeat, otherwise the program will exit: ");
                    txt2 = Console.ReadLine();
                    if(txt2.Equals("r"))
                    {
                        x = 0 ;
                        Console.Clear();
                    }
                    else
                    {
                        keep = false;
                    }
                }    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void quit(string a)
        {
            if(a.Equals("q"))
            {
                Environment.Exit(0);
            }
        }
    }
}
