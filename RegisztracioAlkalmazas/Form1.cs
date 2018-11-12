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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> lista = new List<string>();
            lista.Add("Uszás");
            lista.Add("Horgászat");
            lista.Add("Futás");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nev = (textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string uj_hobbi = (textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("RegisztrációAlkalmazás.txt");

                writer.WriteLine(textBox1.Text);
                writer.WriteLine(dateTimePicker1.Text);

                if (radioButton1.Checked == true){
                    writer.WriteLine("férfi");
                }

                if (radioButton2.Checked == true)
                {
                    writer.WriteLine("nő");
                }


                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox1.Items[i]);
                }
                writer.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("RegisztrációAlkalmazás.txt");

            try
            {
                textBox1.Text = reader.ReadLine();
                dateTimePicker1.Text = reader.ReadLine();
                if (radioButton1.Checked == true)
                {
                    reader.ReadLine();
                }
                if (radioButton2.Checked == true)
                {
                    reader.ReadLine();
                }

                else
                {
                    MessageBox.Show("Sikeres mentés");
                }
                    MessageBox.Show("Sikertelen mentés");


                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    reader.ReadLine((string)listBox1.Items[i]);
                }


            }
            catch(IOException e)
            {
                Console.WriteLine("Hiba");
            }
            reader.Close();
        }

    }
}