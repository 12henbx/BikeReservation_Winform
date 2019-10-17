using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

public enum NoKunci
{
    W123A,
    W124A,
    W125A,
    W126A,
    W127A
}

namespace pbo_form
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form_login_HP());
            Application.Run(new MultiFormContext(new Form1(), new Form_login_HP()));

        }
        public class MultiFormContext : ApplicationContext
        {
            private int openForms;
            public MultiFormContext(params Form[] forms)
            {
                openForms = forms.Length;

                foreach (var form in forms)
                {
                    form.FormClosed += (s, args) =>
                    {
                        //When we have closed the last of the "starting" forms, 
                        //end the program.
                        if (Interlocked.Decrement(ref openForms) == 0)
                            ExitThread();
                    };

                    form.Show();
                }
            }
        }

        //public static System.Collections.ICollection userKaryawan = new String[] { "FakultasTk", "DepanSardjito", "BagianMIPA", "GelangMahasiswa", "PerpusUGM" };
        //public static System.Collections.ICollection passKaryawan = new String[] { "1contohpass", "2contohpass", "3contohpass", "4contohpass", "5contohpass" };
        public static string[] userKaryawan = new string[] { "Fakultas_Teknik", "Depan_Sardjito", "FAK_MIPA", "GelanggangMahasiswa", "Perpus_UGM" };
        public static string[] passKaryawan = new string[] { "1contohpass", "2contohpass", "3contohpass", "4contohpass", "5contohpass" };
        public static string[] nimMahasiswa = new string[] { "415200", "415201", "415202", "415203", "415204" };
        public static string[] passMahasiswa = new string[] { "1contohpass", "2contohpass", "3contohpass", "4contohpass", "5contohpass" };
        //public static ArrayList nomerKunci = new ArrayList();
    }
}
