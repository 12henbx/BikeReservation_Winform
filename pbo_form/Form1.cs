using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbo_form
{
    public partial class Form1 : Form, Interface1
    {
        public string showid { get; set; }
        public int ixuser { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            if (UserBox.Text == "" && PassBox.Text == "")
            {
                MessageBox.Show("Username dan password belum diisi.");
            }
            try
            {
                AutoCompleteStringCollection koleksi = new AutoCompleteStringCollection();
                UserBox.AutoCompleteCustomSource = koleksi;
                bool cekLogin = false;
                for (int i = 0; i < Program.userKaryawan.Length; i++)
                {
                    if (UserBox.Text == Program.userKaryawan[i] && PassBox.Text == Program.passKaryawan[i])
                    {
                        cekLogin = true;
                        showid = Program.userKaryawan[i];
                        ixuser = i;
                        Form2 pindah2 = new Form2(showid, i);
                        pindah2.Show();
                        Close();
                    }
                }
                if (cekLogin == false)
                {
                    MessageBox.Show("Username dan password tidak cocok");
                }
            }
            catch(Exception tangkap)
            {
                Console.WriteLine(tangkap);
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var userKaryawan = new AutoCompleteStringCollection();
            userKaryawan.AddRange(new string[]
                            { "Fakultas_Teknik", "Depan_Sardjito", "FAK_MIPA", "GelanggangMahasiswa", "Perpus_UGM" });
            UserBox.AutoCompleteMode = AutoCompleteMode.Suggest;

            UserBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            UserBox.AutoCompleteCustomSource = userKaryawan;
        }
    }
}
