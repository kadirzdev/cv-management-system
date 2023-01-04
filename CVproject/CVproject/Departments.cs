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
    public partial class Departments: Form
    {
        
        public Departments()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lecorstd.Items.Add("Student");
            lecorstd.Items.Add("Lecturer");
            string departments = Departmentscombo.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database = CVproject ; integrated security = true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Dep_name from Department_data", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    Departmentscombo.Items.Add(rdr.GetString(i));
                }
            }

            rdr.Close();
            con.Close();

            if (lecorstd.Text =="Student")
            {
                cmd.CommandText = "select id = id ,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree from Student_data";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                datatable.DataSource = ds.Tables[0];
            }
            else if(lecorstd.Text =="Lecturer") {
                cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                datatable.DataSource = ds.Tables[0];
            }
            Departmentscombo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Departmentscombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database = CVproject ; integrated security = true ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "select Head_name from Department_data where Dep_name ='" + Departmentscombo.Text + "'";
            string name = cmd.ExecuteScalar().ToString();
            Headtext.Text = name.ToString();
            cmd.CommandText= "select Contact from Department_data where Dep_name ='" + Departmentscombo.Text + "'";
            string contact = cmd.ExecuteScalar().ToString();
            contacttext.Text=contact.ToString();
            cmd.CommandText = "select Email from Department_data where Dep_name ='" + Departmentscombo.Text + "'";
            string email = cmd.ExecuteScalar().ToString();
            Emailtext.Text = email.ToString();

            if (lecorstd.Text == "Student")
            {
                cmd.CommandText = "select id=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree from Student_data where S_depname LIKE '" + Departmentscombo.Text + "%'";
            }
            else if (lecorstd.Text =="Lecturer" )
            {
                cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data where L_department LIKE '"+Departmentscombo.Text+"%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datatable.DataSource = ds.Tables[0];



            con.Close();

        }
        int bid;
        Int64 rowid;
        private void datatable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datatable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(datatable.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (SystemException) { MessageBox.Show("Select true position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select  id=id,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree from Student_data where id =" + bid + "";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

               
               
                




            }
            catch (IndexOutOfRangeException) { }
        }

    }
}
