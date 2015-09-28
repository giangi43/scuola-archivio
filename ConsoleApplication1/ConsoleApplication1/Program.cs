using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        //static void Main(string[] args)
        //{           
        //    testprg help = new testprg();
        //    Person[] archivio = new Person[10];           
        //    archivio = help.buildvector(archivio);

        //    help.printArchive(archivio);
        //    List<ListNode> index = help.joblist(archivio);
        //    Console.WriteLine("=D");            

        //    help.showIndex(Console.ReadLine(), index);


        //    Console.Read();

        //}

        #region cool

        Person[] archivio;
        List<ListNode> index;
        testprg help;
        
        static void Main(string[] args)
        {
            Program a= new Program();
            a.fanculo(a);
             
        }

        

        void fanculo(Program a)
        {
            
             help = new testprg();
            archivio = new Person[10];
            archivio = help.buildvector(archivio);


            index = help.joblist(archivio);
            Console.WriteLine("=D");

            Console.WriteLine("write \"help\" for info");
            a.ReadCommand();

        }

        #region cli

        public Person[] getArchivio() { return archivio; }
        public List<ListNode> getIndex() { return index; }        

        public void WriteLine(String s) { Console.WriteLine(s); }
        public void ReadCommand() { Console.WriteLine(""); Console.Write("giangi># "); if (command(Console.ReadLine())) ReadCommand(); }
        public enum Command : byte { see, erease, help, end }


        bool command(string s)
        {
            Console.WriteLine("");
            if (s.Equals("help") || s.Equals("?")) { return this.helpCommand(); }
            else if (s.Equals("end")) { return false; }
            else if (s.Split(' ')[0].Equals("see") && s.Length > 4) { return this.seeCommand(s); }
            else { Console.WriteLine("unknoun command"); return true; }

        }

        bool seeCommand(string s)
        {
            if (s.Split(' ')[1].Equals("-a"))
            {
                help.printArchive(getArchivio());
                return true;
            }
            else if (s.Split(' ')[1].Equals("help") || s.Split(' ')[1].Equals("?"))
            {
                Console.WriteLine("");
                string[] commands = { "see [] <parameter>", "see [-a]", "see help" };
                string[] utility = { "let you visualize the list based on <parameter>", "let you visualize the archive", "show on screen all the ..." };
                String str = String.Format("{0,-19} {1,-10}\n\n", "commands", "utility");
                for (int index = 0; index < commands.Length; index++)
                    str += String.Format("{0,-19} {1,-10:N0}\n",
                                       commands[index], utility[index]);
                Console.WriteLine(str);
                return true;
            }
            else
                help.showIndex(s.Substring(4), getIndex());

            return true;
        }

        bool helpCommand()
        {
            Console.WriteLine("");
            string[] commands = { "end", "erease", "help", "see" };
            string[] utility = { "terminate the program", "erease a person from a index []", "let you visualize all commands", "print on screen an index [-a]" };
            String str = String.Format("{0,-10} {1,-10}\n\n", "commands", "utility");
            for (int index = 0; index < commands.Length; index++)
                str += String.Format("{0,-10} {1,-10:N0}\n",
                                   commands[index], utility[index]);
            Console.WriteLine(str);
            return true;
        }

        // svalvola

    }
        #endregion
        #endregion
}
