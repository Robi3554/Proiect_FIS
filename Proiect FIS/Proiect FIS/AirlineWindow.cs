using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            leaveTime.ShowUpDown = true;
            leaveTime.Format = DateTimePickerFormat.Custom;
            leaveTime.CustomFormat = "HH:mm";
            arriveTime.ShowUpDown = true;
            arriveTime.Format = DateTimePickerFormat.Custom;
            arriveTime.CustomFormat = "HH:mm";
            
        }

        private void leaveTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugareBtn_Click(object sender, EventArgs e)
        {
            if(codBox.Text != string.Empty || tipBox.Text != string.Empty || fcNr.Text != string.Empty ||
                bcNr.Text != string.Empty || fcPret.Text != string.Empty || bcPret.Text != string.Empty ||
                orasPle.Text != string.Empty || orasSos.Text != string.Empty || leaveDate.Text != string.Empty ||
                leaveTime.Text != string.Empty || arriveDate.Text != string.Empty || arriveTime.Text != string.Empty)
            {
                string connect = @"Data Source=DESKTOP-MER90VE\SQLEXPRESS;Initial Catalog=Aeroport;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string stmt = "insert into Cursa ([Cod_cursa], [Tip_avion], [Nr_locuri_first_class], [Nr_locuri_bussines_class], [Pret_first_class], [Pret_bussines_class], [Oras_plecare], [Oras_sosire], [Data_plecare], [Ora_plecare], [Data_sosire], [Ora_sosire])" +
                    "values (@cc, @ta, @nfc, @nbc, @pfc, @pbc, @op, @os, @dp, @tp, @ds, @ts)";
                SqlCommand sc = new SqlCommand(stmt, cnn);
                sc.Parameters.AddWithValue("@cc", codBox.Text);
                sc.Parameters.AddWithValue("@ta", tipBox.Text);
                sc.Parameters.AddWithValue("@nfc", fcNr.Text);
                sc.Parameters.AddWithValue("@nbc", bcNr.Text);
                sc.Parameters.AddWithValue("@pfc", fcPret.Text);
                sc.Parameters.AddWithValue("@pbc", bcPret.Text);
                sc.Parameters.AddWithValue("@op", orasPle.Text);
                sc.Parameters.AddWithValue("@os", orasSos.Text);
                sc.Parameters.AddWithValue("@dp", leaveDate.Value);
                sc.Parameters.AddWithValue("@tp", leaveTime.Value);
                sc.Parameters.AddWithValue("@ds", arriveDate.Value);
                sc.Parameters.AddWithValue("@ts", arriveTime.Value);
                sc.ExecuteNonQuery();
                cnn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti toate datele!");
            }
            
        }
    }
}
