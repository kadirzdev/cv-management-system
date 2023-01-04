using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace CVproject 
{
    public partial class StdAdd : Form
    {
        public static String path;
        string currentPathx = AppDomain.CurrentDomain.BaseDirectory;
        public StdAdd()
        {
            InitializeComponent();
          
        }

        private void StdAdd_Load(object sender, EventArgs e)
        {
           Datapathtext.Text = AddCV.address;
            path = AddCV.address;

            LAbl.Text = path;
        
            string departments = Departmentscombo.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database = CVproject ; integrated security = true ";
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
            Departmentscombo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (Studentnametext.Text != "" && Studentnotext.Text != "" && Departmentscombo.Text != "" && Internshiptext.Text != ""
                    && Birthdatetext.Text != "" && Contacttext.Text != "" && Degreetext.Text != "" && Addresstext.Text != "" && Emailtext.Text != "" && Datapathtext.Text != "")
                {


                    String fileName = path;
                    String newpath;
                    if (!Directory.Exists(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\"))
                    {
                        Directory.CreateDirectory(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\");
                        String destinationPath = Path.Combine(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                        File.Copy(fileName, destinationPath, overwrite: true);
                        newpath = destinationPath;

                    }
                    else
                    {

                        String destinationPath = Path.Combine(currentPathx + "Students\\" + Studentnotext.Text.ToString() + "\\", Path.GetFileName(fileName));
                        File.Copy(fileName, destinationPath, overwrite: true);
                        newpath = destinationPath;
                    }



                    String Studentname = Studentnametext.Text;
                    Int64 Studentno = Int64.Parse(Studentnotext.Text);
                    String SDepartment = Departmentscombo.Text;
                    String SInternship = Internshiptext.Text;
                    String SBirthdate = Birthdatetext.Text;
                    Int64 SContact = Int64.Parse(Contacttext.Text);
                    String SDegree = Degreetext.Text;
                    String SAddress = Addresstext.Text;
                    String SEmail = Emailtext.Text;




                    byte[] pdf = null;
                    FileStream stream = new FileStream(Datapathtext.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    pdf = brs.ReadBytes((byte)stream.Length);


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CVproject.mdf; database=CVproject; integrated security = True ; Pooling=false ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into Student_data(S_id,S_Name,S_depname,S_contact,S_Email,S_Datebirth,S_intern,S_address,S_degree,S_cvpath) values(" + Studentno + ",'" + Studentname + "','" + SDepartment + "'," + SContact + ",'" + SEmail + "','" + SBirthdate + "','" + SInternship + "','" + SAddress + "','" + SDegree + "','" + newpath + "')";
                    cmd2.CommandText = "insert into CV_data(CV_id,Type,Dep_name,St_name) values (" + Studentno + ",@pdf,'" + SDepartment + "','" + Studentname + "')";
                    cmd2.Parameters.Add(new SqlParameter("@pdf", pdf));

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved", "Success ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
                else
                {
                    MessageBox.Show("Please, fill in all the boxes !", "Empty box not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }





            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

     









        }
    }
}
