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
    public partial class Dashboard : Form
    {
        private Form activateForm; 

        bool sidebarExpand;
        bool desktoppanelexpand;

        bool mousedown;
        private Point offset;




        public Dashboard()
        {
            InitializeComponent();
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            //set the max and min ize Sidebar
            int x = Desktoppanel.Size.Width;
            int y = Desktoppanel.Size.Height;
         
                if (sidebarExpand)
                {

                    //if sidebar is expand, then minimize ! 
                    Sidebar.Width -= 10;
                Desktoppanel.Size = new Size(x +10, y);
                Desktoppanel.Location = new Point(Desktoppanel.Location.X- 10, Desktoppanel.Location.Y);
               
                   
                    if (Sidebar.Width == Sidebar.MinimumSize.Width)
                    {   
                        
                      
                      sidebarExpand = false;
                        
                      
                        Sidebartimer.Stop();
                        


                    }
                }   
                else 
                {
                    Sidebar.Width += 10;
                Desktoppanel.Size = new Size(x -10, y);
                Desktoppanel.Location = new Point(Desktoppanel.Location.X +10, Desktoppanel.Location.Y);
             

                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                    {
                       
                                  
                        sidebarExpand = true;
                      
                        Sidebartimer.Stop();
                    }
                }

         

    {

            }
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
           //Start sidebartimer
            Sidebartimer.Start();
            paneltimer.Start();

        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildform(new CVicon());

        }

    
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult end;
            end= MessageBox.Show("Are you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (end == DialogResult.No)
            {
                //MessageBox.Show(""); //anything
            }
            if (end == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Studentbutton_Click(object sender, EventArgs e)
        {

            OpenChildform(new Studentinfos());
        }
        private void OpenChildform (Form childform)
        {
            if (activateForm!= null)
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

        private void Lecturerbutton_Click(object sender, EventArgs e)
        {
            OpenChildform(new Lecturerinfos());
        }

        private void paneltimer_Tick(object sender, EventArgs e)
        {
            //set the max and min ize Sidebar

            if (desktoppanelexpand)
            {

                //if sidebar is expand, then minimize ! 
                Desktoppanel.Width -= 10;


                if (Desktoppanel.Width == Desktoppanel.MinimumSize.Width)
                {


                    desktoppanelexpand = false;


                    paneltimer.Stop();



                }
            }
            else
            {
                Desktoppanel.Width += 10;

                if (Desktoppanel.Width == Desktoppanel.MaximumSize.Width)
                {

                    desktoppanelexpand = true;

                    paneltimer.Stop();
                }
            }



            {

            }

        }

        private void Viewcvbutton_Click(object sender, EventArgs e)
        {
            OpenChildform(new Viewcv());
        }

        private void AddCV_Click(object sender, EventArgs e)
        {
            OpenChildform(new AddCV());
        }

        private void DepartmentsButton_Click(object sender, EventArgs e)
        {
            OpenChildform(new Departments());
        }

        private void Desktoppanel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y; 
            mousedown = true;
        }

        private void Desktoppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X-offset.X, currentScreenPos.Y-offset.Y);
            }
        }

        private void Desktoppanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }



    }

