using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        bool vai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
      
        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {
                       
        }

        
        private void lblRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("D:/Facultad/Laboratorio/Practica/C#/Parcial/UltimoUsuario.txt");
            {
                sw.WriteLine($"{txbUsuario.Text}");

            }
            sw.Close();
           


            if(txbContraseña.Text!="P.a.s.s.")
            {
                MessageBox.Show("Contraseña incorrecta, intente de nuevo.");
                this.Hide();
                this.Show();
            }


            bool existe = false;
            StreamReader sr = File.OpenText("D:/Facultad/Laboratorio/Practica/C#/Parcial/Usuarios.txt");
            {
                string? linea;
                while(!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    if (linea==txbUsuario.Text)
                    {
                        existe = true;
                        
                    }
                    
                }
               
            }
            if ((existe==true) && (txbContraseña.Text=="P.a.s.s."))
            {
                this.Hide();
                Form3 formulario = new Form3();
                formulario.Show();

            }
            if ((existe == false))
            {
                MessageBox.Show("Usuario Incorrecto, intente de nuevo.");
            }
            sr.Close();

            Form3 inicio = new Form3();
            inicio.lblCuenta_Automatico(sender, e);




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbOcultar_Click_1(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txbContraseña.PasswordChar = '*';
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txbContraseña.PasswordChar = '\0';
        }

       
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
