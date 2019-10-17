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
    public partial class Form_login_HP : Form
    {
        public Form_login_HP()
        {
            InitializeComponent();

            
        }
        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool cekLogin = false;
            AutoCompleteStringCollection koleksi = new AutoCompleteStringCollection();
            UserBox.AutoCompleteCustomSource = koleksi;
            try
            {
                if (UserBox.Text == "" && PassBox.Text == "")
                {
                    MessageBox.Show("Username dan password belum diisi.");

                }
                for (int i = 0; i < Program.nimMahasiswa.Length; i++)
                {
                    if (UserBox.Text == Program.nimMahasiswa[i] && PassBox.Text == Program.passMahasiswa[i])
                    {
                        cekLogin = true;
                        //String showid = Program.nimMahasiswa[i];
                        Form_HP pindah3 = new Form_HP();
                        pindah3.Show();
                        //Close();
                    }
                }
                if (cekLogin == false)
                {
                    MessageBox.Show("Username dan password tidak cocok");
                }
            }
            catch
            {

            }
        }

        private void Form_login_HP_Load(object sender, EventArgs e)
        {
            var nimMahasiswa = new AutoCompleteStringCollection();
            nimMahasiswa.AddRange(new string[]
                            { "415200", "415201", "415202", "415203", "415204" });
            UserBox.AutoCompleteMode = AutoCompleteMode.Suggest;

            UserBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            UserBox.AutoCompleteCustomSource = nimMahasiswa;
        }
    }
}
