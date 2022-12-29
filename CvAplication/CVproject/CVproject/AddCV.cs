using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVproject
{
    public partial class AddCV : Form
    {
        
        private Form activateForm;

        
        public AddCV()
        {
            InitializeComponent();
             }

        private void Form2_Load(object sender, EventArgs e)
        {
            Lecorstd.Items.Add("Lecturer");
            Lecorstd.Items.Add("Student");
          
      
           

        }private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            else if (Lecorstd.Text== "Lecturer")
            {
                OpenChildform(new LecAdd());

            }

        }
    }
}
