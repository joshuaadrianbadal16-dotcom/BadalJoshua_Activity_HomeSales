using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BadalJoshua_Activity_HomeSales
{
    public partial class Form2 : Form
    {
        public Form2(double Danielle, double Edward, double Fatima)
        {
            InitializeComponent();

            Lbl_Summary.Text =
                "Danielle: " + Danielle.ToString("C2") + "\n\n" +
                "Edward: " + Edward.ToString("C2") + "\n\n" +
                "Fatima: " + Fatima.ToString("C2") + "\n\n" +
                "--------------------------\n" +
                "Grand Total: " +
                (Danielle + Edward + Fatima).ToString("C2");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
