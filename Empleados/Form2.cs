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
    public partial class Form2 : Form
    {
        bool vai = false;
        int i = 1;
        public Form2()
        {
           
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }



        private void pboxCancelarNE_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
                        
        }

       

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            
            try
            {
                txbDNI_TextChanged(sender, e);
                    this.Hide();
                Form1 formulario = new Form1();
                formulario.Show();

                using (StreamWriter sw = File.AppendText("D:/Facultad/Laboratorio/Practica/C#/Parcial/Empleados.txt"))
                {
                    sw.WriteLine($"{txbApellido.Text}|{txbNombre.Text}|{txbDNI.Text}|{dtpFecha.Text}|{txbCalle.Text} {txbNumero.Text} {txbPiso.Text} {txbDpto.Text}");


                }

                string nombre = txbNombre.Text;
                string nombreParaTxt = nombre.ToLower()[0] + txbApellido.Text.ToLower();


                StreamWriter sd = File.CreateText("D:/Facultad/Laboratorio/Practica/C#/Parcial/temporal.txt");
                StreamReader sr = new StreamReader("D:/Facultad/Laboratorio/Practica/C#/Parcial/Usuarios.txt");

                string? linea;
                bool ok = false;

                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    if (linea == nombreParaTxt)
                    {
                        ok = true;

                    }
                    sd.WriteLine(linea);
                }
                if (ok != true)
                {
                    sd.WriteLine(nombreParaTxt);
                    MessageBox.Show($"Su nuevo usuario es {nombreParaTxt}");

                }
                else
                {
                    i++;
                    if (this.i <= nombre.Length)
                    {

                        string nombreSecParaTxt = nombre.Substring(0, i).ToLower() + txbApellido.Text.ToLower();
                        sd.WriteLine(nombreSecParaTxt.ToLower());
                        MessageBox.Show($"Su nuevo usuario es {nombreSecParaTxt}");
                    }

                }
                

                sd.Close();
                sr.Close();

                File.Delete("D:/Facultad/Laboratorio/Practica/C#/Parcial/Usuarios.txt");
                File.Move("D:/Facultad/Laboratorio/Practica/C#/Parcial/temporal.txt", "D:/Facultad/Laboratorio/Practica/C#/Parcial/Usuarios.txt");
                
            }
            catch(Exception a)
            { Console.WriteLine (a.Message); 
            }
            
            

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbDNI_TextChanged(object sender, EventArgs e)
        {
            if((txbDNI.Text.Length <7 )||(txbDNI.Text.Length >8))

            {
                MessageBox.Show("El DNI debe contener 7 u 8 digitos.");
                throw new Exception("e");
            }
            
            
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {
            if (txbNumero.Text.Length >= 4)
            {
                MessageBox.Show("El número de la calle supera los 3 digitos");
            }
        }

        private void txbPiso_TextChanged(object sender, EventArgs e)
        {
            if (txbPiso.Text.Length >= 4)
            {
                MessageBox.Show("El número del piso contiene dos cifras o más");
            }
        }

        private void txbCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbLegajo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblLegajoNumAutomatico(object sender, EventArgs e)
        {

          
        }

        private void lblLegajo_Click(object sender, EventArgs e)
        {

        }

        private void lblLegajoNum_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }

        private void txbDNI_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }

}