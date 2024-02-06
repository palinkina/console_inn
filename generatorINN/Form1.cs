using System;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using generatorINN.Properties;
using System.Resources;



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
            // Button.MouseH System.Drawing.Bitmap

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Выбирите ОПФ";



            if (rBJ.Checked && textBox1 != null)
            {
                // textBox1.Clear();
                textBox1.Text = Verification_for_Juridical();

                //textBox1.Text = "77" + InnHelper.GenerateRandomString(9);


            }
            if (rBI.Checked)
            {

                textBox1.Text = Verification_for_Individual();
            }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rBJ_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                textBox1.Text = "Вы выбрали ЮЛ" /*radioButton.Text*/;
            }
        }

        private void rBI_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                textBox1.Text = "Вы выбрали ФЛ/ИП" /*radioButton.Text*/;
            }

        }

        public static Random rnd = new Random();
        private int first_FJ = 42; //первые две цифры (77) на 4,2 - типо для ЮЛ 
        private int b;
        private int n1;
        private int n2;
        private string endstr;

        public string Verification_for_Juridical()// список с 7 рандомными числами 
        {
            endstr = null;
            List<int> numbers = new List<int>();

            //   number = GenerateRandomString(7);
            //    num = int.Parse(number);
            //    numbers.Add(new InnData(num));
            for (int i = 0; i < 7; i++)
            {
                numbers.Add(rnd.Next(0, 10));
            }
            // n10 = 7*2 + 7*4 + (inn[0] * 10) + inn[0] * 3;



            b = first_FJ + numbers[0] * 10 + numbers[1] * 3 + numbers[2] * 5 + numbers[3] * 9 + numbers[4] * 4 + numbers[5] * 6 + numbers[6] * 8;
            b = b % 11;
            if (b == 10)
            {
                b = 0;
            }

            foreach (int element in numbers)
            {
                //element.ToString();
                endstr = endstr + element;
            }
            string b1 = b.ToString();
            endstr = "77" + endstr + b;
            return endstr;

        }
        private string Verification_for_Individual()
        {
            endstr = null;
            int first_FI_1 = 7 * 7 + 7 * 2;
            int first_FI_2 = 7 * 3 + 7 * 7;

            List<int> numbers = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                numbers.Add(rnd.Next(0, 10));
            }
            n1 = first_FI_1 + numbers[0] * 4 + numbers[1] * 10 + numbers[2] * 3 + numbers[3] * 5 + numbers[4] * 9 + numbers[5] * 4 + numbers[6] * 6 + numbers[7] * 8;
            n1 = n1 % 11;
            n2 = first_FI_2 + numbers[0] * 2 + numbers[1] * 4 + numbers[2] * 10 + numbers[3] * 3 + numbers[4] * 5 + numbers[5] * 9 + numbers[6] * 4 + numbers[7] * 6 + n1 * 8;
            n2 = n2 % 11;
            if (n1 == 10)
            {
                n1 = 0;
            }
            if (n1 == 10)
            {
                n1 = 0;
            }
            foreach (int element in numbers)
            {

                endstr = endstr + element;
            }
            endstr = "77" + endstr + n1 + n2;

            return endstr;
        }




        /*
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static global::System.Globalization.CultureInfo resourceCulture;
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INNGenForm));
        */
        private void button_MouseEnter(object sender, EventArgs e)
        {
          //  if (textBox1.Text != null)
            
           //     textBox1.Text = "HELP";
          //  BackgroundImage = (Image)resources.GetObject("pepeangry");


        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
           // if (textBox1.Text == "HELP")
           // textBox1.Clear();
        }
        //сделать не фоном, а картиночным боксом 
        
    }
}