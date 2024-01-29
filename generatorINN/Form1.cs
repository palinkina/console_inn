using System;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;



namespace generatorINN
{
    public partial class INNGenForm : Form
    {
        public INNGenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = InnHelper.ReadFromJsonFile();
            //textBox1.Text = "77" + InnHelper.GenerateRandomString(10);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void INNGenForm_KeyDown(object sender, KeyEventArgs e) //нажатие через клавиватуру 
        {
            // не забудь про key preview = true и событие key down
            if (e.KeyValue == (char)Keys.Enter)
            {
                Button1_Click(button, null); // не красит в красный и при нажатии запускает подряд нажатия !!
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}