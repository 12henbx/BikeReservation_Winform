using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace pbo_form
{
    
    public class globalarr
    {
        //public static Status[] strStatus = new Status[10];
        public static Status[] strStatus = Enumerable.Repeat(Status.Tersedia, 10).ToArray();
        //Parallel.For(0, 10, index => strStatus[index] = Status.Tersedia);
    }
    public class Mahasiswa {
        //public Mahasiswa{
            public String idM;
            public String kodeM; 
            public String kunciM;
        //}
        public void data(String idM, String kodeM, String kunciM)
        {
            this.idM = idM;
            this.kodeM = kodeM;
            this.kunciM = kunciM;
            
        }

    }
    public enum Status
    {
        Pending,
        Dipakai,
        Tersedia
    };
}
