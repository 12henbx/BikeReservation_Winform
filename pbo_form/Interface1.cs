using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbo_form
{
    interface Interface1
    {
        string showid { get; set; }
        int ixuser { get; set; }
    }
    interface Kkunci
    {
        string outKunci { get; set; }
    }
    interface Imetod
    {
        void datKunci(int ixuser);
        void kunciStasiun(int ixuser);
    }
}
