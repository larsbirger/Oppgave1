using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oppgave1
{
    enum Farge {RØD, BLÅ, GRØNN, GUL, HVIT, LILLA, BRUN, UKJENT}
    class Klubb
    {

        //oppg a
          string _klubbNavn = ""; 
          public int _antallMedlemmer = 0;
        
        // oppg b 
        public string? klubbNavn
        {
            get { return _klubbNavn; }
            set
            {
                _klubbNavn = value?.Length > 0 ? value ?? "x" : "x";
            }
        }

        public int? antallMedlemmer 
        {
            get { return _antallMedlemmer; }
            set
            {
                _antallMedlemmer = value >= 0 ? value ?? 0 : 0;
            }
        }
        // oppg c 
        // obs se enum over klassen, men under namespace 

        Farge _draktFarge; 
        
        public Farge? draktFarge
        {
            get{ return _draktFarge; }
            set
            {
                _draktFarge = Enum.IsDefined(value ?? 0) ? value ?? Farge.UKJENT : Farge.UKJENT;
            }
        }
        
        // oppg d 

        public Klubb(string? klubbNavn, int? antallMedlemmer, Farge? draktFarge)
        {
            this.klubbNavn = klubbNavn;
            this.antallMedlemmer = antallMedlemmer;
            this.draktFarge = draktFarge;
        }

        public string SkrivUt(bool? line = false, bool? print = true)
        {
            string tmp = "tesktformatet me ønsker klubben på";
            if (print ?? true)
            {
                Console.Write(tmp);
                
                if (line ?? false) Console.WriteLine();
            }
            return tmp;
        }
    }
}
