using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbo_form
{
    class CnomerKunci : Interface1
    {
        public String[] kunciFakultas = new String[] { "A120", "A121", "A122", "A123", "A124", "A125", "A126", "A127", "A128", "A129" };
        public String[] kunciSardjito = new String[] { "B120", "B121", "B122", "B123", "B124", "B125", "B126", "B127", "B128", "B129" };
        public String[] kunciMipa = new String[] { "C120", "C121", "C122", "C123", "C124", "C125", "C126", "C127", "C128", "C129" };
        public String[] kunciGelanggang = new String[] { "D120", "D121", "D122", "D123", "D124", "D125", "D126", "D127", "D128", "D129" };
        public String[] kunciPerpus = new String[] { "E120", "E121", "E122", "E123", "E124", "E125", "E126", "E127", "E128", "E129" };

        public string showid { get; set; }
        public int ixuser { get; set; }
    }
    
}

