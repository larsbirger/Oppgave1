
namespace Oppgave1
{
    internal class FotballKlubb : Klubb
    {
        // oppg f
        private static int _divisjon;

        //KlubbNavn = klubbNavn;
        //AntallMedelemmer = antallMedelemmer;
        //DraktFarge = draktFarge; 
        //Divisjon = divisjon;

        public int? divisjon
        {
            get { return _divisjon; }
            set 
            {
                _divisjon = value >= 0 ? value ?? 0 : 0;
                //if (_divisjon < 0) value = 0;  // satte value til 0 for vet ikke hva som er laveste divisjon  
            } 
        }

        // oppg g

        string _land = ""; // for å la dette datamedlemet oppdateres utenfor klassen må det ikke være static 

        public string? land
        {
            get => _land ?? "";
            set => _land = value ?? "";    
        }

        // oppg h 

        List<string> Spillere = new List<string>();

        // oppg i 

        public FotballKlubb(string? klubbNavn, int? antallMedlemmer, Farge? draktFarge, int? divisjon, string? land = "")
            : base(klubbNavn: klubbNavn, antallMedlemmer: antallMedlemmer, draktFarge:draktFarge)
        {
            this.divisjon = divisjon;
            this.land = land;
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
            // if (H && B = )  
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
