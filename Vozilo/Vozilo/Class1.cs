using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    public class Vozilo
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Vrsta { get; set; }
        public string VoziPo { get; set; }

        public Vozilo(string marka, string model, string vrsta)
        {
            Marka = marka;
            Model = model;
            Vrsta = vrsta;
        }
    }
}
}
