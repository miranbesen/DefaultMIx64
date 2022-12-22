using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMIx64.Entities
{
    public class Kesisim
    {
        public int Id { get; set; }
        public double Kesisim_Alan { get; set; }
        public string Kesisim_Il { get; set; }

        public Nokta Kesisen_Merkez_Nokta { get; set; }

        public override string ToString()
        {
            return Kesisim_Il + "(" + Kesisim_Alan + " km2)";
        }
    }
}
