using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVproject
{
    public partial class Viewcv : Form
    {
        public Viewcv()
        {
            InitializeComponent();
        }
       
       

        private void Form2_Load(object sender, EventArgs e)
        {
            cvcombo.Items.Add("Student");
            cvcombo.Items.Add("Lecturer");
            cvcombo.DropDownStyle= ComboBoxStyle.DropDownList;  
           


        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cvcombo.Text == "Student")
                {
                    Int64 a = Int64.Parse(IDtext.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select S_cvpath from Student_data where S_id=" + a + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    link.Text = ds.Tables[0].Rows[0][0].ToString();
                    axAcroPDF1.src = link.Text;

                }
                else if (cvcombo.Text == "Lecturer")
                {
                    Int64 a = Int64.Parse(IDtext.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select L_cvpath from Lec_data where L_id=" + a + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    link.Text = ds.Tables[0].Rows[0][0].ToString();
                    axAcroPDF1.src = link.Text;

                }
            }catch (Exception ex) { MessageBox.Show("Please enter number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }
    }
}
