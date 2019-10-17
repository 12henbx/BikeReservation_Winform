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
    public struct SKode
    {
        public int urutan;

    };

    public partial class Form_HP : Form
    {
        SKode st;
        public Form_HP()
        {
            InitializeComponent();
            
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static string RandomString(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //st.urutan++;
            String tampilKode = RandomString(5);
            tampilBox.Text = tampilKode;
            kodeAcak.Add(tampilKode);
        }
        //public static string[] kodeAcak = new string[] {};
        //public static System.Collections.ICollection kodeAcak = new String[] { };
        public static ArrayList kodeAcak = new ArrayList();
    }
}
