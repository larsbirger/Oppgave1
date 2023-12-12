using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave1
{
    enum farge {RØD, BLÅ, GRØNN, GUL, HVIT, LILLA, BRUN, UKJENT}
    internal class Klubb
    {

        //oppg a
          public string klubbNavn; 
          public int antallMedlemmer;
        
        // oppg b 
        public string KlubbNavn
        {
            get { return klubbNavn; }
            set
            {
                if (klubbNavn = "") value = "x"; 
                else if (klubbNavn = string.Empty) value = "x";
                else (klubbNavn = value);  

            }
        }

        public int AntallMedlemmer 
        {
            get { return antallMedlemmer; }
            set
            {
                if (value < 0) value = 0;
                else antallMedlemmer = value ;
            }
        }
        // oppg c 
        // obs se enum over klassen, men under namespace 

        farge draktFarge; 
        
        public farge DraktFarge
        {
            get{ return draktFarge; }
            set{ draktFarge = value; }
        }
        
        // oppg d 

        public Klubb()
        {
            antallMedlemmer = 0;
        }

        public Klubb(int antallMedlemmer, string klubbNavn, farge draktFarge)
        {
            AntallMedlemmer = antallMedlemmer;
            KlubbNavn = klubbNavn;
            DraktFarge = draktFarge;
        }
    }
}
