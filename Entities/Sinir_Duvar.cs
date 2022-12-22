using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMIx64.Entities
{
    public class Sinir_Duvar
    {
        public int Id { get; set; }
        public string Sinir_Adi { get; set; }
        public string Il { get; set; }
        public double Sinir_Uzunluk { get; set; }
        public List<KesisimUzunluk> Kesisim_Listesi { get; set; }

        public override string ToString()
        {
            return "SinirAdi("+Sinir_Adi +")" +"SinirUzunluk"+"(" + Sinir_Uzunluk + " m2)";
        }
    }
}
