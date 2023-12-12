using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Security.Cryptography;
using System.Net;
using System.Collections.Immutable;

namespace Oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // oppg m

            Klubb k1 = new Klubb(2, "haugesund", farge.RØD);
            Klubb k2 = new Klubb(2, "bergem", farge.BLÅ);
            Klubb k3 = new Klubb(2, "førde", farge.BRUN);

            //FotballKlubb FK1 = new FotballKlubb("haugesund",2,farge.RØD, "ola norman", "hans norman"); // konstruktøren tar bare 4 argument og ingen av de er navn på spillerer på må finne på noe  
            //FotballKlubb FK2 = new FotballKlubb("bergen",2 , farge.BLÅ, "nils norman","sigurd norman");
            //FotballKlubb FK3 = new FotballKlubb("førde", 2, farge.BRUN , "aleksander norman","per norman" );

            FotballKlubb FK1 = new FotballKlubb("haugesund", 2, farge.RØD, 1);
            FotballKlubb FK2 = new FotballKlubb("bergen", 2, farge.BLÅ,2);
            FotballKlubb FK3 = new FotballKlubb("førde", 2, farge.BRUN, 3);


            List<Klubb> fotball = new List<Klubb>(); 
            fotball.Add(k1);
            fotball.Add(k2);
            fotball.Add(k3);
            fotball.Add(FK1);
            fotball.Add(FK2);
            fotball.Add(FK3);


            foreach (Klubb n in fotball)
            {
                n.ToString();
                Console.WriteLine();
            }

            // oppg n 


            List<Klubb> fotball2 = new List<Klubb>();
            fotball2.Add(FK1);
            fotball2.Add(FK2);
            fotball2.Add(FK3);

            fotball2.Sort(); // må sortere med ToCompare og Icomparer for å få rett utskrift 


            fotball.Sort(); // sortere etter alfabetisk navn  

            foreach (fotball n in fotball)
            {
                n.SkrivUt();
                Console.WriteLine();
            }

            // oppg o


            fotball.Sort(); // sortere etter antall noe må endre litt eller bytte til annen fungsjon som boble sortering 



            foreach (fotball2 n in fotball)
            {
                n.SkrivUt();
                Console.WriteLine();
            }



            public bool SammenliknDraktFarge(Klubb første, Klubb andre) // sammenligne klubber sin drakt farge 
            {
                bool svar = false;
                if (første.Klubb == andre.Klubb) svar = true;
                return svar;
            }

        }
    }
}