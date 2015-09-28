using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ListNode
    {
        ListNode next;
        //ListNode other;
        Person p;
        string s;


        public ListNode(Person p, string s) { this.p = p; this.s = s;  }

        #region get/set parameters

        public void setNext(ListNode l){ next=l;}
       // public void setOther(ListNode l) { other = l; }
        void setPerson(Person l) { p = l; }
        void setParameter(string l) { s=l;}

        public ListNode getNext() { return next; }
       // public ListNode getOther() { return other; }
        public Person getPerson() { return p; }
        public string getParameter() { return s; }

        #endregion

        public bool isLast() { if (this.next == null) return false; return true; }
       // public bool isThereOther() { if (this.other == null) return false; return true; }

        public string ToString(){return p.ToString();}

        // add a new son node as last
        public void addLast(Person p)
        {
            if (this.isLast()) { this.getNext().addLast(p); }
            else
                this.setNext(new ListNode(p, p.getJob()));
        }

        // print this node and the son ones
        public void printIndex()
        {
            Console.WriteLine(this.ToString());
            if (this.isLast())
                this.getNext().printIndex();

        }

        #region remove person
        // sobstitute th first with the last in the index
        public void removePerson(Person p) 
        {
            if (this.getPerson().Equals(p)) { this.setPerson(this.getLast()); this.removeLast(); }

            else if (this.isLast())
            {
                this.removePerson0(p);
            }
        }

        // remove a node letting the father node takeing the son node of the one which will get ereased
        void removePerson0(Person p) 
        {
            if (this.getNext().getPerson().Equals(p))
            {
                this.setNext(this.getNext().getNext());
            }
            else
                this.getNext().removePerson0(p);
        }
        #endregion

        // return the person of the last node
        Person getLast()
        {
            if (this.isLast())
            {
                return this.getNext().getLast();
            }
            return this.getPerson();
        }

        #region remove last
        // change the person with an empty person 
        public void removeLast() 
        {
            if (this.isLast())
            {
                     this.removeLast0();           
            }
            else
                this.setPerson(new Person());
        }

        //remove the last removeing the pointer to the last node from the second last
        void removeLast0() 
        {
            if (this.getNext().isLast())
            {
                this.getNext().removeLast0();
            }
            else
                this.setNext(null);
        }
        #endregion

    }
}
