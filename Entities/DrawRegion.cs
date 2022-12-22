using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMIx64.Entities
{
    public class DrawRegion
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public double Alan { get; set; }

        public List<String> alanArr { get; set; }
        public List<String> sehirArr { get; set; }


    }
}
