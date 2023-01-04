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
    public partial class Studentinfos : Form
    {
        public Studentinfos()
        {
            InitializeComponent();
        }

        string currentPathx = AppDomain.CurrentDomain.BaseDirectory;
        public static String path;
        string oldpath;
       
        private void Studentinfos_Load(object sender, EventArgs e)
        {
          

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id = id ,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree ,S_cvpath as Path from Student_data";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Studentinfosdata.DataSource = ds.Tables[0];

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

        private void Studentinfosdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Studentinfosdata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(Studentinfosdata.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (SystemException) { MessageBox.Show("Select true position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
             
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select  id=id,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree,S_cvpath as CVlocation from Student_data where id =" + bid + "";
                    
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                Studentnametext.Text = ds.Tables[0].Rows[0][1].ToString();
                Studentnotext.Text = ds.Tables[0].Rows[0][2].ToString();
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

        private void Studentnamesearch_TextChanged(object sender, EventArgs e)
        {
            if (Studentnamesearch.Text != " ")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree,S_cvpath as CVlocation from Student_data where S_Name LIKE '" + Studentnamesearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Studentinfosdata.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "selectid=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree,S_cvpath as CVlocation  from Student_data";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               Studentinfosdata.DataSource = ds.Tables[0];

            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            Studentnamesearch.Clear();
            Studentnosearch.Clear();
            Studentnametext.Clear();
            Studentnotext.Clear();
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
            cmd.CommandText = "select id = id ,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree ,S_cvpath as Path from Student_data";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Studentinfosdata.DataSource = ds.Tables[0];


        }
        public void SQLconnection(String CON)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = CON;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {   try
            {
                if (MessageBox.Show("Data will be updated . Are you confrim this ? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    path = CVpathtext.Text;
                    String fileName = path;
                    String newpath = "empty";

                    try
                    {

                        if (!Directory.Exists(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\"))
                        {

                            Directory.CreateDirectory(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\");
                            String destinationPath = Path.Combine(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                            File.Copy(fileName, destinationPath, overwrite: true);
                            newpath = destinationPath;
                            File.Delete(oldpath);

                        }
                        else
                        {

                            Directory.CreateDirectory(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\");
                            String destinationPath = Path.Combine(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                            File.Copy(fileName, destinationPath, overwrite: true);
                            newpath = destinationPath;
                            File.Delete(oldpath);

                        }


                    }
                    catch (Exception ex) { }


                    String sname = Studentnametext.Text;
                    Int64 sno = Int64.Parse(Studentnotext.Text);
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
                        cmd.CommandText = "update Student_data set S_id='" + sno + "', S_Name='" + sname + "', S_depname ='" + sdepartment + "',S_contact='" + scon + "',S_email ='" + semail + "',S_Datebirth='" + birth + "',S_intern='" + intern + "',S_Address='" + address + "',S_degree='" + degree + "' where id=" + rowid + "";

                    }
                    else
                    {
                        cmd.CommandText = "update Student_data set S_id='" + sno + "', S_Name='" + sname + "', S_depname ='" + sdepartment + "',S_contact='" + scon + "',S_email ='" + semail + "',S_Datebirth='" + birth + "',S_intern='" + intern + "',S_Address='" + address + "',S_degree='" + degree + "',S_cvpath='" + newpath + "' where id=" + rowid + "";

                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "select id = id ,S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree,S_cvpath as CVlocation from Student_data";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Studentinfosdata.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Data will be deleted . Are you confrim this ? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    Int64 sd = Int64.Parse(Studentnotext.Text);





                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";

                
                    File.Delete(deletepath.Text);





                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete from CV_data where Cv_id = " + sd + "";
                    cmd.CommandText = "delete from Student_data where id = '" + rowid + "'";


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);



                }
            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Studentnosearch_TextChanged(object sender, EventArgs e)
        {
            if (Studentnamesearch.Text != " ")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree,S_cvpath as CVlocation from Student_data where S_id LIKE '" + Studentnosearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Studentinfosdata.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf ; database =CVproject; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree, S_cvpath as CVlocation from Student_data";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Studentinfosdata.DataSource = ds.Tables[0];

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
                cmd.CommandText = "select id=id, S_Name as Name,S_id as ID,S_depname as Department,S_contact as Contact,S_Email as Email,S_Datebirth as Age,S_intern as Intern,S_address as Address,S_degree as Degree, S_cvpath as CVlocation  from Student_data where S_depname LIKE '" + Departmentsearch.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Studentinfosdata.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void UploadCVbutton_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF |*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CVpathtext.Text = ofd.FileName;
                }
            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
    }
