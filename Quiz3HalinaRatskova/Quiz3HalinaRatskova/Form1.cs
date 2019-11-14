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

namespace Quiz3HalinaRatskova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            cbMark.Items.Add("Toyota");
            cbMark.Items.Add("Kia");
            cbMark.Items.Add("Audi");

            cbYear.Items.Add("2019");
            cbYear.Items.Add("2018");
            cbYear.Items.Add("2017");




        }

        private void cbMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();

            //Toyota
            if (cbMark.SelectedIndex == 0)
            {
                cbModel.Items.Add("Camry");
                cbModel.Items.Add("Venza");
                cbModel.Items.Add("Matrix");

            }
            //Kia
            if (cbMark.SelectedIndex == 1)
            {
                cbModel.Items.Add("Sportage");
                cbModel.Items.Add("Rio");
                cbModel.Items.Add("Sorento");

            }


            //Audi

            if (cbMark.SelectedIndex == 2)
            {
                cbModel.Items.Add("Q3");
                cbModel.Items.Add("A4");
                cbModel.Items.Add("Q7");

            }
        }

        private void car_CheckedChanged(object sender, EventArgs e)
        {
            grBoxOwner.Enabled = !grBoxOwner.Enabled;

        }

        private void owner_CheckedChanged(object sender, EventArgs e)
        {
            grBoxCar.Enabled = !grBoxCar.Enabled;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbMark.Text = "";
            cbModel.Text = "";
            cbYear.Text = "";
            fname.Text = "";
            lname.Text = "";
            ph.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((cbMark.Text == "") || (cbModel.Text == "") || (cbYear.Text == "") || (fname.Text == "") || (lname.Text == "") || (ph.Text == ""))
            {
                MessageBox.Show("Fill out all fields.");
            }
            else
            {


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();


                saveFileDialog1.InitialDirectory = @"C:\projects\save.txt";
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grBoxOwner.Text = saveFileDialog1.FileName;

                }


                FileStream stream =
                    new FileStream(@"C:\projects\save.txt", FileMode.Append, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("First name: " + fname.Text + " " + "Last name: " + lname.Text + " " + "Telephone: " + ph.Text + " " +"Mark: "+ cbMark.Text + " " +"Model: "+ cbModel.Text + " " +"Year: "+ cbYear.Text + " ", @"C:\projects\save.txt");
                }

                MessageBox.Show("User registred");

            }
            }
        }
    }


