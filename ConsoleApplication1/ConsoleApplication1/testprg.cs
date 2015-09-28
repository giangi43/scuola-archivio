using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class testprg
    {        
        Random x;

        #region show index
        //public void printIndex(ListNode ln) {           
       //    Console.WriteLine( ln.ToString());
       //    if(ln.isLast())
       //    printIndex(ln.getNext());

       //}

       public void showIndex(string s, List<ListNode> ln) 
       {          
           for (int i = 0; i < ln.Count; i++)
           {               
               if (String.Equals(s, ln[i].getParameter(),StringComparison.OrdinalIgnoreCase)) {
                   ln[i].printIndex();
               }
           }
       }
        #endregion

        #region generate index

       // build the job's lists
       public List<ListNode> joblist(Person[] pv)
       {
           bool b;
           List<ListNode> job = new List<ListNode>();           
           job.Add(new ListNode(pv[0],pv[0].getJob()));           
           for (int i = 1; i < pv.Length; i++)
           {
               b = true;
               for (int j = 0; j < job.Count && b; j++)
               {
                   if (pv[i].getJob().Equals(job[j].getParameter())&& b)
                    {
                        job[j].addLast(pv[i]);
                        b = false ;                        
                    }                  
               }
               if (b)
               {
                   job.Add(new ListNode(pv[i], pv[i].getJob()));                   
               }
           }
           return job;
       }

       

       // add a new son node
       //void addLast(Person p, ListNode ln)
       //{
       //    if (ln.isLast()) { addLast(p, ln.getNext()); }
       //    else 
       //    ln.setNext(new ListNode(p, p.getJob())); 
       //}

#endregion

        #region che cazzata
       // // build thhe job's lists
       //public ListNode joblist(Person[] pv) {
       //    ListNode job=new ListNode();
       //    int n=0;
       //    job.setParameter(pv[0].getJob());
       //    job.setPerson(pv[0]);
       //    for (int i = 1; i <pv.Length ; i++)
       //    {
       //        if (isParameterDifferent(pv[i],job))
       //         {
       //             addOther(pv[i], job);
       //         }
         
                             
       //    }

       //    return job;

       //}



       // // add a new parallel list 
       //void addOther(Person p, ListNode ln) {
       //    if (ln.isThereOther()) { addOther(p, ln.getOther()); }
       //    ln.setOther(new ListNode(p,p.getJob()));
       //}

       // // evaluate if there is no parallel list for the person  // if a list is there add a person
       //bool isParameterDifferent(Person p, ListNode ln) {
       //    if (ln.isThereOther()) {
       //        if (ln.getParameter().Equals(p.getJob()))
       //         {

       //            //add person if there is a list 
       //             addLast(p, ln);

       //            return false;
       //         }
       //        return isParameterDifferent( p, ln.getOther());
       //        }
       //    return true;
       //}

       //// add a new son node
       //void addLast(Person p, ListNode ln)
       //{
       //    if (ln.isLast()) { addLast(p, ln.getNext()); }
       //    ln.setNext(new ListNode(p, p.getJob()));
       //}



        #endregion

        #region fill the archive

       // build a vector of people
       public Person[] buildvector(Person[] pv) {
           x = new Random();
           x.Next(8);           
            for (int i = 0; i < pv.Length; i++)
            {                   
                pv[i] = new Person(namefiller(x.Next()), lastnamefiller(x.Next()), redditofiller(x.Next()), jobfiller(x.Next()));                
            }
           
            return pv;
        }

        
        public void printArchive(Person[] pv)
        {
            foreach (Person p in pv)
            {
                Console.WriteLine(p.ToString());
            }
        }

        // randomize name for a person object
       string namefiller(int r) 
       {
            x=new Random(r);
            string[] names = new string[8];
            names[0]="Marco";
            names[1] = "Michele";
            names[2] = "Alberto";
            names[3]="Federico";
            names[4]="Umberto";
            names[5]="Davide";
            names[6]="Costantino";
            names[7]="Giovanni";            
            
            return names[x.Next(8)];
        }

       // randomize lastname for a person object
        string lastnamefiller(int r)
        {
            x = new Random(r);
            string[] names = new string[8];
            names[0] = "sanna";
            names[1] = "piras";
            names[2] = "maxia";
            names[3] = "melis";
            names[4] = "caria";
            names[5] = "figus";
            names[6] = "stevelli";
            names[7] = "todde";            
           
            return names[x.Next(8)];
        }

        // randomize jobs for a person object
        string jobfiller(int r)
        {
            x = new Random(r);
            string[] names = new string[8];
            names[0] = "medico";
            names[1] = "falegname";
            names[2] = "impiegato";
            names[3] = "pittore";
            names[4] = "scultore";
            names[5] = "attore";
            names[6] = "disoccupato";
            names[7] = "chimico";
            
            return names[x.Next(8)];
        }

        // randomize salary for a person object
        double redditofiller(int r) {
            x = new Random(r);
            return x.Next(10000);
        }
       
       #endregion

    }
}
