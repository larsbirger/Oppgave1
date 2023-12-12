using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oppgave1
{
    internal class FotballKlubb : Klubb
    {
        // oppg f
        private static int divisjon;

        public int Divisjon
        {
            get { return divisjon; }
            set 
            { 
                if (divisjon < 0) value = 0;  // satte value til 0 for vet ikke hva som er laveste divisjon  
            } 
        }

        // oppg g

        string land; // for å la dette datamedlemet oppdateres utenfor klassen må det ikke være static 

        public string Land
        {
            get => land;
            set => land = value;    
        }

        // oppg h 

        List<string> Spillere = new List<string>();

        // oppg i 

        public FotballKlubb(string klubbnavn, int antallMedelemmer, farge draktFarge, int divisjon) // kan eventuellt bruke : base(string klubbnavn, int antallMedelemmer, string draktFarge)
        {
            KlubbNavn = klubbNavn;
            AntallMedelemmer = antallMedelemmer;
            DraktFarge = draktFarge;
            Divisjon = divisjon;
        }


        // oppg j 
        public override string ToString()
        {
            string svar;
            svar = string.Format("klubbNavn: {0}   draktFarge: {1}", klubbNavn, draktFarge);
            return svar;
        }

        // oppg k 
        //  Opprett et funksjonsmedlem ved navn SpillerMot, som tar et tilsvarende objekt
        //  som argument og returnerer ‘H’ dersom kampen går på hjemmebane og ‘B’ dersom
        //  det spilles på bortebane.SpillerMot skal være tilgjengelig utenfor klassen.Hvor
        //  vidt det skal returneres ‘H’ eller ‘B’ skal bestemmes tilfeldig i hvert oppkall.
        string SpillerMot
        { 
          get { return SpillerMot; }
          set 
          {
            if (H && B = )  
          }        
        }


        // oppg l

    
        public string SammeDraktFarge
        {
            get => SammeDraktFarge;
            set => SammeDraktFarge = value;



        }


    }
}
