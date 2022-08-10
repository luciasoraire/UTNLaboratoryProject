using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login

{ 
    public partial class Form3 : Form
    {
        private const int widthSlide = 194;
        private const int widthSlideIcon = 45;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaptura();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        bool vai = false;


        public Form3()
        {
            InitializeComponent();
            InitializeSetting();
        }
        public void InitializeSetting()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            HideSubMenus();
        }
        private void HideSubMenus()
        {
            panelSubMenu.Visible = false;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
         

           
        }

        private void txbEmpleadoingresado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void lblSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            
            ShowSubMenu(panelSubMenu);
        }
              
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;

            }
            else subMenu.Visible = false;
        }

        private void picBoton_Click(object sender, EventArgs e)
        {
            if (panelSlideMenu.Width!= widthSlideIcon)

            {
                panelSlideMenu.Width = widthSlideIcon;
                HideSubMenus();
                panelSlideMenu.Visible = false;

            }
            else
            {
                panelSlideMenu.Width = widthSlide;
                panelSlideMenu.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
             
            Form4 frm = new Form4();
            frm.TopLevel = false;
            panelGrilla.Controls.Add(frm);
            
            frm.Show();
            frm.button1_Click(sender, e);
        
          
           
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

       

        private void panelTop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
      
        

      

        private void panelGrilla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBuscador_Paint(object sender, PaintEventArgs e)
        {

        }

        public void lblCuenta_Automatico(object sender, EventArgs e)
        {
            string nombreusuario = null;
            string? linea;
            StreamReader sr = File.OpenText("D:/Facultad/Laboratorio/Practica/C#/Parcial/UltimoUsuario.txt");
            

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea != null)
                {
                    nombreusuario = linea;
                }

            }

            sr.Close();
            lblCuenta.Text = nombreusuario;

        }

      

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}

