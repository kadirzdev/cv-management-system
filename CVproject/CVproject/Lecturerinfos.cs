using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CVproject
{
    public partial class Lecturerinfos: Form
    {
        public Lecturerinfos()
        {
            InitializeComponent();
        }

        string currentPathx = AppDomain.CurrentDomain.BaseDirectory;
        public static String path;
        string oldpath;

        private void Lecturerinfos_Load(object sender, EventArgs e)
        {
          

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lecturerinfosdata.DataSource = ds.Tables[0];

            string departments = Departmentscombo.Text;
          
          
            con.Open();

            cmd = new SqlCommand("select Dep_name from Department_data", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    Departmentscombo.Items.Add(rdr.GetString(i));
                    Departmentsearch.Items.Add(rdr.GetString(i));
                }
            }

            rdr.Close();
            con.Close();
            Departmentscombo.DropDownStyle = ComboBoxStyle.DropDownList;
            Departmentsearch.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        int bid;
        Int64 rowid;

        private void Lecturerinfosdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Lecturerinfosdata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(Lecturerinfosdata.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (SystemException) { MessageBox.Show("Select true position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
             
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path  from Lec_data where id =" + bid + "";
                    
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                Lecturernametext.Text = ds.Tables[0].Rows[0][1].ToString();
                Lecturernotext.Text = ds.Tables[0].Rows[0][2].ToString();
                Departmentscombo.Text = ds.Tables[0].Rows[0][3].ToString();
                Contacttext.Text = ds.Tables[0].Rows[0][4].ToString();
                Emailtext.Text=ds.Tables[0].Rows[0][5].ToString();
                Birthdatetext.Text = ds.Tables[0].Rows[0][6].ToString();
                Internshiptext.Text = ds.Tables[0].Rows[0][7].ToString();
                Addresstext.Text = ds.Tables[0].Rows[0][8].ToString();
                Degreetext.Text = ds.Tables[0].Rows[0][9].ToString();
                CVpathtext.Text = ds.Tables[0].Rows[0][10].ToString(); 

                deletepath.Text= ds.Tables[0].Rows[0][10].ToString();

            }
            catch (IndexOutOfRangeException) { }
            oldpath = CVpathtext.Text;

        }

        private void Lecturernamesearch_TextChanged(object sender, EventArgs e)
        {
            if (Lecturernamesearch.Text != " ")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data where S_Name LIKE '" + Lecturernamesearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Lecturerinfosdata.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data ";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               Lecturerinfosdata.DataSource = ds.Tables[0];

            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            Lecturernamesearch.Clear();
            Lecturernosearch.Clear();
            Lecturernametext.Clear();
            Lecturernotext.Clear();
            Departmentscombo.ResetText();

            Contacttext.Clear();
            Emailtext.Clear();
            Birthdatetext.Clear();
            Internshiptext.Clear();
            Addresstext.Clear();
            Degreetext.Clear();
            CVpathtext.Clear();
         
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lecturerinfosdata.DataSource = ds.Tables[0];

        }
        public void SQLconnection(String CON)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = CON;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be updated . Are you confrim this ? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    path = CVpathtext.Text;
                    String fileName = path;
                    String newpath = "empty";



                    try
                    {
                        if (!Directory.Exists(currentPathx + "Lecturer\\" + Lecturernotext.Text.ToString() + "\\"))
                        {


                            Directory.CreateDirectory(currentPathx + "Lecturer\\" + Lecturernotext.Text.ToString() + "\\");
                            String destinationPath = Path.Combine(currentPathx + "Lecturer\\" + Lecturernotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                            File.Copy(fileName, destinationPath, overwrite: true);
                            newpath = destinationPath;
                            File.Delete(oldpath);
                        }
                        else
                        {

                            Directory.CreateDirectory(currentPathx + "Lecturer\\" + Lecturernotext.Text.ToString() + "\\");
                            String destinationPath = Path.Combine(currentPathx + "Lecturer\\" + Lecturernotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                            File.Copy(fileName, destinationPath, overwrite: true);
                            newpath = destinationPath;
                            File.Delete(oldpath);
                        }
                    }
                    catch (Exception ex) { }

                    String sname = Lecturernametext.Text;
                    Int64 sno = Int64.Parse(Lecturernotext.Text);
                    String sdepartment = Departmentscombo.Text;
                    Int64 scon = Int64.Parse(Contacttext.Text);
                    String semail = Emailtext.Text;
                    String birth = Birthdatetext.Text;
                    String intern = Internshiptext.Text;
                    String address = Addresstext.Text;
                    String degree = Degreetext.Text;




                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    if (string.Equals("empty", newpath))
                    {
                        cmd.CommandText = "update Lec_data set L_id='" + sno + "', L_name='" + sname + "', L_department ='" + sdepartment + "',L_contact='" + scon + "',L_email ='" + semail + "',L_birthdate='" + birth + "',L_intern='" + intern + "',L_address='" + address + "',L_degree='" + degree + "'where id = " + rowid + "";


                    }
                    else
                    {
                        cmd.CommandText = "update Lec_data set L_id='" + sno + "', L_name='" + sname + "', L_department ='" + sdepartment + "',L_contact='" + scon + "',L_email ='" + semail + "',L_birthdate='" + birth + "',L_intern='" + intern + "',L_address='" + address + "',L_degree='" + degree + "',L_cvpath='" + newpath + "' where id=" + rowid + "";

                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data ";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Lecturerinfosdata.DataSource = ds1.Tables[0];

            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be deleted . Are you confrim this ? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    File.Delete(deletepath.Text);

                    Int64 sd = Int64.Parse(Lecturernotext.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete from CV_data where Cv_id = " + sd + "";
                    cmd.CommandText = "delete from Lec_data where id = '" + rowid + "'";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Lecturernosearch_TextChanged(object sender, EventArgs e)
        {
            if (Lecturernamesearch.Text != " ")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data  where L_id LIKE '" + Lecturernosearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Lecturerinfosdata.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data ";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Lecturerinfosdata.DataSource = ds.Tables[0];

            }

        }

        private void Departmentsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Departmentsearch.Text != null)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "id = id ,L_name as Name,L_id as ID,L_department as Department,L_contact as Contact,L_email as Email,L_birthdate as Age,L_intern as Intern,L_address as Address,L_degree as Degree ,L_cvpath as Path from Lec_data  where L_department LIKE '" + Departmentsearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Lecturerinfosdata.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void UploadCVbutton_Click(object sender, EventArgs e)
        {try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF |*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CVpathtext.Text = ofd.FileName;
                }
            }
            catch (Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         
        }

       
    }
    }
