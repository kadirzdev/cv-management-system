using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVproject
{
    public partial class AddCV : Form
    {

        private Form activateForm;

        public static String address;

  


        public AddCV()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Lecorstd.Items.Add("Lecturer");
            Lecorstd.Items.Add("Student");

            Lecorstd.DropDownStyle = ComboBoxStyle.DropDownList;



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void OpenChildform(Form childform)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.Desktoppanel.Controls.Add(childform);
            this.Desktoppanel.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        private void Lecorstd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lecorstd.Text == "Student")
            {
                OpenChildform(new StdAdd());

            }
            else if (Lecorstd.Text == "Lecturer")
            {
                OpenChildform(new LecAdd());

            }

        }

        private void Uploadpdf_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF |*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;


                }
                Pdftext.Text = ofd.FileName;
                address = ofd.FileName;

                if (Lecorstd.Text == "Student")
                {
                    OpenChildform(new StdAdd());
                }
                else if (Lecorstd.Text == "Lecturer")
                {
                    OpenChildform(new LecAdd());
                }
            }catch(Exception ex) { MessageBox.Show("Something missing! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Pdftext_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
