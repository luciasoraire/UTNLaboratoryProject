using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            StreamReader sr = File.OpenText("D:/Facultad/Laboratorio/Practica/C#/Parcial/Empleados.txt");
         string? linea;
            int i=1;
            while(!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                string[] vec = new string[4];
                if (linea!=null)
                {
                    vec = linea.Split('|');

                }
                
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = i;
                dataGridView1.Rows[n].Cells[1].Value = vec[0] + " " + vec[1];
                dataGridView1.Rows[n].Cells[2].Value = vec[2];
                dataGridView1.Rows[n].Cells[3].Value = vec[3];
                dataGridView1.Rows[n].Cells[4].Value = vec[4];
                i++;

            }

            sr.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string nbusq = txbBusq.Text;
            dataGridView1.Rows.Clear();
            

            StreamReader sr = File.OpenText("D:/Facultad/Laboratorio/Practica/C#/Parcial/Empleados.txt");
            string? linea;
            int j = 1;
            
            while (!sr.EndOfStream)
            {
                
                linea = sr.ReadLine();
                string[] vec = new string[4];
                if (linea != null)
                {
                    vec = linea.Split('|');

                }
                for (int i = 0; i < vec.Length; i++)
                {
                    if (vec[i] == txbBusq.Text)
                    {

                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = j;
                        dataGridView1.Rows[n].Cells[1].Value = vec[0] + " " + vec[1];
                        dataGridView1.Rows[n].Cells[2].Value = vec[2];
                        dataGridView1.Rows[n].Cells[3].Value = vec[3];
                        dataGridView1.Rows[n].Cells[4].Value = vec[4];
                        j++;

                    }
                }

            }
            sr.Close();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.button1_Click(sender, e);
            
            this.Show();
        }
    }
}
