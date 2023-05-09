using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class AirlineWindow : Form
    {

        public AirlineWindow()
        {
            InitializeComponent();
            leaveTime2.ShowUpDown = true;
            leaveTime2.Format = DateTimePickerFormat.Custom;
            leaveTime2.CustomFormat = "HH:mm";
            arriveTime2.ShowUpDown = true;
            arriveTime2.Format = DateTimePickerFormat.Custom;
            arriveTime2.CustomFormat = "HH:mm";
        }

        private void leaveTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugareBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
