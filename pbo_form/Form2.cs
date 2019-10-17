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
    public partial class Form2 : Form, Interface1, Imetod
    {
        public string showid { get; set; }
        public int ixuser { get; set; }
        CnomerKunci objekKunci = new CnomerKunci();
        
        
        public Form2(String showid, int ixuser)
        {
            InitializeComponent();
            sambut.Text = "Selamat datang di " + showid;
            this.ixuser = ixuser;
            CreateListView();
            
        }
        private void CreateListView()
        {
            ListView listView1 = new ListView();
            listView1.View = View.Details;
            listView1.Columns.Add("No Kunci", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", -2, HorizontalAlignment.Left);
        }

        public static ArrayList listKode = new ArrayList();
        public static ArrayList kunciDipakai = new ArrayList();
        public void kunciStasiun(int ixuser)
        {
            switch (ixuser)
            {
                case 0:
                    tiapStasiun(objekKunci.kunciFakultas);
                    break;
                case 1:
                    tiapStasiun(objekKunci.kunciSardjito);
                    break;
                case 2:
                    tiapStasiun(objekKunci.kunciMipa);
                    break;
                case 3:
                    tiapStasiun(objekKunci.kunciGelanggang);
                    break;
                case 4:
                    tiapStasiun(objekKunci.kunciPerpus);
                    break;

            }
        }
        public void datKunci(int ixuser)
        {
            switch (ixuser)
            {
                case 0:
                    datangStasiun(objekKunci.kunciFakultas);
                    break;
                case 1:
                    datangStasiun(objekKunci.kunciSardjito);
                    break;
                case 2:
                    datangStasiun(objekKunci.kunciMipa);
                    break;
                case 3:
                    datangStasiun(objekKunci.kunciGelanggang);
                    break;
                case 4:
                    datangStasiun(objekKunci.kunciPerpus);
                    break;

            }
        }
        private void inputBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                foreach (string str in Form_HP.kodeAcak)
                {
                    if (inputBox.Text == str)
                    {
                        //for (int j = 0; j < objekKunci.kunciFakultas.Length; j++)
                        //{
                        //    if (globalarr.strStatus[j] == Status.Tersedia)
                        //    {
                        //        globalarr.strStatus[j] = Status.Dipakai;
                        //        outKunci.Text = objekKunci.kunciFakultas[j];

                        //        listView1.Items.Clear();
                        //        for (int i = 0; i < nomerKunci.Length; i++)
                        //        {
                        //            string[] row = { nomerKunci[i], globalarr.strStatus[i].ToString() };
                        //            var listViewItem = new ListViewItem(row);
                        //            listView1.Items.Add(listViewItem);
                        //        }
                        //        break;
                        //    }
                        //}
                        kunciStasiun(ixuser);
                        kunciDipakai.Add(outKunci.Text + str);
                        listKode.Add(str);
                        Form_HP.kodeAcak.Remove(str);
                        count++;
                    }
                }
            }
            catch (Exception tepar)
            {
                Console.WriteLine(tepar);
            }
        }

        public void listViewClr()
        {
            listView1.Items.Clear();
        }

        private void datangButton_Click(object sender, EventArgs e)
        {
            String datangKode = datangBox.Text;
            try
            {
                foreach (string str in listKode)
                {
                    if (datangKode == str)
                    {
                        //for (int i = 0; i < nomerKunci.Length; i++)
                        //{
                        //    if (globalarr.strStatus[i] == Status.Dipakai)
                        //    {
                        //        globalarr.strStatus[i] = Status.Tersedia;
                        //        listView1.Items.Clear();
                        //        for (int j = 0; j < nomerKunci.Length; j++)
                        //        {
                        //            string[] row = { nomerKunci[j], globalarr.strStatus[j].ToString() };
                        //            var listViewItem = new ListViewItem(row);
                        //            listView1.Items.Add(listViewItem);
                        //        }
                        //        break;
                        //    }
                        //}
                        datKunci(ixuser);
                        MessageBox.Show("Terima kasih telah mengembalikan kunci");
                        Form_HP.kodeAcak.Add(datangKode);
                        listKode.Remove(datangKode);
                        Form_HP.kodeAcak.Remove(datangKode);
                    }
                }
            }
            catch (Exception teparr)
            {
                Console.WriteLine(teparr);
            }
        }

        private void tiapStasiun(string[] nomerKunci)
        {
            for (int j = 0; j < nomerKunci.Length; j++)
            {
                if (globalarr.strStatus[j] == Status.Tersedia)
                {
                    globalarr.strStatus[j] = Status.Dipakai;
                    outKunci.Text = nomerKunci[j];

                    //listView1.Items.Clear();
                    listViewClr();
                    for (int i = 0; i < nomerKunci.Length; i++)
                    {
                        string[] row = { nomerKunci[i], globalarr.strStatus[i].ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                    break;
                }
            }
        }
        private void datangStasiun(string[] nomerKunci)
        {
            for (int i = 0; i < nomerKunci.Length; i++)
            {
                if (globalarr.strStatus[i] == Status.Dipakai)
                {
                    globalarr.strStatus[i] = Status.Tersedia;
                    //listView1.Items.Clear();
                    listViewClr();
                    for (int j = 0; j < nomerKunci.Length; j++)
                    {
                        string[] row = { nomerKunci[j], globalarr.strStatus[j].ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                    break;
                }
            }
        }
        //public static String[] nomerKunci = new String[] { "A120", "A121", "A122", "A123", "A124", "A125", "A126", "A127", "A128", "A129" };
    }
}
