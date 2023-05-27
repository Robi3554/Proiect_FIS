using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_FIS
{
    public partial class Angajat : Form
    {
        int pretTotal;
        string email;
        string tel;

        public Angajat()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nrBilete = Int32.Parse(textBox3.Text) + Int32.Parse(textBox4.Text);

            if (!IsDigitOnly(tel))
            {
                telBox.Focus();
                errorProvider2.SetError(telBox, "Va rog sa nu introduceti litere!");
            }
            if (string.IsNullOrEmpty(mailTxt.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(mailTxt, "Va rog introduceti un e-mail!");
            }
            else if (!string.IsNullOrWhiteSpace(mailTxt.Text))
            {
                if (!CheckMail(email))
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
                    sc.Parameters.AddWithValue("@nc", " ");
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

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> results = new List<string>();
            int firstC = 0;
            int bussinesC = 0;


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
                //con.Close();
                da.Dispose();
                ds.Dispose();
            }
            else
            {
                reader.Close();
                reader.Dispose();
                MessageBox.Show("Nu s-a gasit cursa!");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            SqlCommand locFc = new SqlCommand("select Nr_locuri_first_class from Cursa where Oras_plecare='" + pleBox.Text + "'", con);

            SqlDataReader reader1 = locFc.ExecuteReader();
            while (reader1.Read())
            {
                if (reader1["Nr_locuri_first_class"] != DBNull.Value)
                {
                    int locFcOrdinal = reader1.GetOrdinal("Nr_locuri_first_class");
                    firstC = reader1.GetInt32(locFcOrdinal);
                }
                if (firstC < Int32.Parse(textBox3.Text))
                {
                    MessageBox.Show("Nu s-a gasit cursa!");
                    //reader1.Close();
                    //reader1.Dispose();
                }
            }
            reader1.Close();
            reader1.Dispose();
            SqlCommand locBc = new SqlCommand("select Nr_locuri_bussines_class from Cursa where Oras_plecare='" + pleBox.Text + "'", con);
            SqlDataReader reader2 = locBc.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2["Nr_locuri_bussines_class"] != DBNull.Value)
                {
                    int locBcOrdinal = reader2.GetOrdinal("Nr_locuri_bussines_class");
                    bussinesC = reader2.GetInt32(locBcOrdinal);
                }
                if (bussinesC < Int32.Parse(textBox4.Text))
                {
                    MessageBox.Show("Nu sa gasit cursa!");
                    //reader1.Close();
                    //reader1.Dispose();
                }
            }

            con.Close();
            reader.Close();
            reader.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nrFc = int.Parse(textBox3.Text);
            int nrBc = int.Parse(textBox4.Text);
            int nrAd = int.Parse(textBox1.Text);
            int nrCop = int.Parse(textBox2.Text);
            int fcPret = 0;
            int bcPret = 0;

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
                    pretBox.Text = PretDusIntors(fcPret, nrAd, nrCop).ToString();
                }
                else
                {
                    pretBox.Text = PretDus(fcPret, nrAd, nrCop).ToString();
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
                    pretBox.Text = PretDusIntors(bcPret, nrAd, nrCop).ToString();
                }
                else
                {
                    pretBox.Text = PretDus(bcPret, nrAd, nrCop).ToString();
                }
            }
        }
        public int PretDus(int x, int y, int z)
        {
            pretTotal = (z * x) - (z * 100) + (y * x);
            //pretBox.Text = pretTotal.ToString();
            return pretTotal;
        }

        public int PretDusIntors(int x, int y, int z)
        {
            pretTotal = (z * x) - (z * 100) + (y * x);
            pretTotal = pretTotal - pretTotal / 3;
            //pretBox.Text = pretTotal.ToString();
            return pretTotal;
        }

        public bool CheckMail(string m)
        {
            m = mailTxt.Text;
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if(expr.IsMatch(m))
            {
                return true;
            }
            return false;
        }

        public bool IsDigitOnly(string str)
        {
            str = telBox.Text;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
