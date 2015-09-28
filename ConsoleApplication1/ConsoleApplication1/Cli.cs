using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //public class Cli
    //{
    //    testprg t;
    //    Program prog;
        
        
    //    public Cli();

    //    public void setTestprg(testprg T) { t = T; }
    //    public void setProgram(Program PROG) { prog = PROG; }

    //    public void WriteLine(String s) { Console.WriteLine(s); }
    //    public void ReadCommand() { Console.Write("giangi># "); if (command(Console.ReadLine())) ReadCommand(); }
    //    public enum Command : byte { see, erease, help, end }


    //    bool command(string s)
    //    {
    //        if (s.Equals("help") || s.Equals("?")) { return this.helpCommand(); }
    //        else if (s.Equals("end")) { return false; }
    //        else if (s.ElementAt(0).Equals('s') && s.ElementAt(1).Equals('e') && s.ElementAt(2).Equals('e') && s.Length > 4) { return this.seeCommand(s); }
    //        else { Console.WriteLine("unknoun command"); return true; }

    //    }

    //    bool seeCommand(string s)
    //    {
    //        if (s.Split(' ')[1].Equals("-a"))
    //        {
    //            t.printArchive(prog.getArchivio());
    //            return true;
    //        }
    //        else
    //            t.showIndex(s.Substring(4), prog.getIndex());

    //        return true;
    //    }

    //    bool helpCommand()
    //    {
    //        Console.WriteLine("");
    //        string[] commands = { "end", "erease", "help", "see" };
    //        string[] utility = { "terminate the program", "erease a person from a index []", "let you visualize all commands", "print on screen an index [-a]" };
    //        String s = String.Format("{0,-10} {1,-10}\n\n", "commands", "utility");
    //        for (int index = 0; index < commands.Length; index++)
    //            s += String.Format("{0,-10} {1,-10:N0}\n",
    //                               commands[index], utility[index]);
    //        Console.WriteLine(s);
    //        Console.WriteLine("");
    //        return true;
    //    }



    //}
}
