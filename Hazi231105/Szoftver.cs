using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi231105
{
    internal class Szoftver
    {
        public int Sorszam { get; set; }
        public string Nev {  get; set; }
        public string LicenszType { get; set; }
        public string[] OPrendszerek { get; set; }
        public string Kategoria {  get; set; }
        public double Ertekeles {  get; set; }
        public double Ar {  get; set; }
        public int AdoKulcs {  get; set; }

        public Szoftver(string sor) 
        {
            var v = sor.Split('|');
            Sorszam = int.Parse(v[0]);
            Nev = v[1];
            LicenszType = v[2];
            OPrendszerek = v[3].Split(',');
            Kategoria = v[4];
            Ertekeles = double.Parse(v[5]);
            Ar = double.Parse(v[6]);
            AdoKulcs = int.Parse(v[7]);
        }

        public override string ToString()
        {
            return $"Sorszam:  {Sorszam}, Nev:  {Nev}, Licensz típus:  {LicenszType}, Operációs rendszerek:  {OPrendszerek}, Értékelés:  {Ertekeles}, Ár:  {Ar}, Adókulcs:  {AdoKulcs}";
        }

        public double Brutto(double Ar, int AdoKulcs)
        {
            return Ar * (100 + AdoKulcs / 100);
        }
    }
}
