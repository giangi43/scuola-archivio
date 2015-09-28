using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Person
    {
        string  CF ;
        string NOME;
        string COGNOME;
        string PROFESSIONE;
        double REDDITO;

        public Person() 
        {
            NOME = "-";
            COGNOME = "-";
            REDDITO = 0;
            PROFESSIONE = "-";
            CF = "-";   

        }

        public Person( string nome, string cognome, double reddito, string professione)
        {
            NOME = nome;
            COGNOME = cognome;
            REDDITO = reddito;
            PROFESSIONE = professione;
            CF = cffiller();            
        }

        string cffiller()
        {
            return ""+this.COGNOME.ElementAt(0) + this.COGNOME.ElementAt(1) + this.COGNOME.ElementAt(2) + this.NOME.ElementAt(0) + this.NOME.ElementAt(1) + this.NOME.ElementAt(2) + Convert.ToString(this.REDDITO);
        } 

        public Person(string cf, string nome, string cognome, double reddito, string professione)
        {
            CF = cf;
            NOME = nome;
            COGNOME = cognome;
            REDDITO = reddito;
            PROFESSIONE = professione;
        }

        public string getCf() { return CF; }
        public string getJob() { return PROFESSIONE; }

        public string ToString() { return CF + ", " + NOME + ", " + COGNOME + ", " + REDDITO + ", " + PROFESSIONE + ";"; }
       
    }
}
