using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMIx64.Entities
{
    public class Maden_Ocagi
    {
        public int Id { get; set; }
        public string Sirket_Adi { get; set; }
        public string Il { get; set; }
        public double Kapladigi_Alan { get; set; }
        
        public List<Kesisim> Kesisim_Listesi { get; set; }

        public override string ToString()
        {
            return Sirket_Adi+"("+ Kapladigi_Alan+" km2)";
        }
    }
}
