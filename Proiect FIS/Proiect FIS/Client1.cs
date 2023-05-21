using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proiect_FIS
{
    public partial class Client1 : Form
    {
        public Client1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> results = new List<string>();


            string connect = @"Data Source=DESKTOP-MER90VE\SQLEXPRESS;Initial Catalog=Aeroport;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand check = new SqlCommand("select * from Cursa where Oras_plecare='" + pleBox.Text + "'", con);
            SqlDataReader reader = check.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                reader.Dispose();
                string stmt = "select * from Cursa where Oras_plecare='" + pleBox.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(stmt, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Cursa");
                dataGridView1.DataSource = ds.Tables["Cursa"].DefaultView;
                con.Close();
                da.Dispose();
                ds.Dispose();
            }
            else
            {
                MessageBox.Show("Nu sa gasit cursa!");
            }
            
            reader.Close();
            reader.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = mailTxt.Text;
            int nrBilete = Int32.Parse(textBox3.Text) + Int32.Parse(textBox4.Text);

            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (string.IsNullOrEmpty(mailTxt.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(mailTxt, "Va rog introduceti un e-mail!");
            }
            else if (!string.IsNullOrWhiteSpace(mailTxt.Text))
            {
                if (!(expr.IsMatch(email)))
                {
                    textBox1.Focus();
                    errorProvider1.SetError(mailTxt, "Va rog introduceti un e-mail valid!");
                }
                else
                {
                    string connect = @"Data Source=DESKTOP-MER90VE\SQLEXPRESS;Initial Catalog=Aeroport;Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string stmt = "insert into Client ([Nume], [Prenume], [Email], [Telefon], [Varsta], [Nr_card], [Nr_bilete], [Total_platit])" +
                        "values (@nu, @pr, @em, @te, @va, @nc, @nb, @tpl)";
                    SqlCommand sc = new SqlCommand(stmt, cnn);
                    sc.Parameters.AddWithValue("@nu", nuBox.Text);
                    sc.Parameters.AddWithValue("@pr", prBox.Text);
                    sc.Parameters.AddWithValue("@em", mailTxt.Text);
                    sc.Parameters.AddWithValue("@te", telBox.Text);
                    sc.Parameters.AddWithValue("@va", ansBox.Text);
                    sc.Parameters.AddWithValue("@nc", cardBox.Text);
                    sc.Parameters.AddWithValue("@nb", nrBilete.ToString());
                    sc.Parameters.AddWithValue("@tpl", pretBox.Text);
                    sc.ExecuteNonQuery();
                    cnn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Client1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nrFc = int.Parse(textBox3.Text);
            int nrBc = int.Parse(textBox4.Text);
            int nrAd = int.Parse(textBox1.Text);
            int nrCop = int.Parse(textBox2.Text);
            int fcPret = 0;
            int bcPret = 0;
            int pretTotal;

            string connect = @"Data Source=DESKTOP-MER90VE\SQLEXPRESS;Initial Catalog=Aeroport;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand sfc = new SqlCommand("select Pret_first_class from Cursa where Oras_plecare='" + pleBox.Text + "'", con);
            SqlCommand sbc = new SqlCommand("select Pret_bussines_class from Cursa where Oras_plecare='" + pleBox.Text + "'", con);
            if (nrFc != 0)
            {
                SqlDataReader reader1 = sfc.ExecuteReader();
                while (reader1.Read())
                {
                    if (reader1["Pret_first_class"] != DBNull.Value)
                    {
                        int sfcOrdinal = reader1.GetOrdinal("Pret_first_class");
                        fcPret = reader1.GetInt32(sfcOrdinal);
                    }
                }
                if (intBtn.Checked == true)
                {
                    pretTotal = (nrCop * fcPret) - (nrCop * 100) + (nrAd * fcPret);
                    pretTotal = pretTotal - pretTotal / 3;
                    pretBox.Text = pretTotal.ToString();
                }
                else
                {
                    pretTotal = (nrCop * fcPret) - (nrCop * 100) + (nrAd * fcPret);
                    pretBox.Text = pretTotal.ToString();
                }
            }
            else if (nrBc != 0)
            {
                SqlDataReader reader2 = sbc.ExecuteReader();
                while (reader2.Read())
                {
                    if (reader2["Pret_bussines_class"] != DBNull.Value)
                    {
                        int sbcOrdinal = reader2.GetOrdinal("Pret_bussines_class");
                        bcPret = reader2.GetInt32(sbcOrdinal);
                    }
                }
                if (intBtn.Checked == true)
                {
                    pretTotal = (nrCop * bcPret) - (nrCop * 100) + (nrAd * bcPret);
                    pretTotal = pretTotal - pretTotal / 3;
                    pretBox.Text = pretTotal.ToString();
                }
                else
                {
                    pretTotal = (nrCop * bcPret) - (nrCop * 100) + (nrAd * bcPret);
                    pretBox.Text = pretTotal.ToString();
                }
            }
        }
    }
}
