using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Average_Calculator
{
    public partial class FormCalculator : Form
    {
        bool clicked = false;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = ratings.Text.ToString();

            string[] sourceSplitted = source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] digits = new double[sourceSplitted.Length];

            bool error = false;

            for (int i = 0; i < sourceSplitted.Length; i++)
            {
                try
                {
                    digits[i] = double.Parse(sourceSplitted[i]);

                    if (digits[i] > 6)
                    {
                        MessageBox.Show("Въвели сте число по-голямо от 6!");
                        error = true;
                    }
                    if (digits[i] < 2)
                    {
                        MessageBox.Show("Въвели сте число по-малко от 2!");
                        error = true;
                    }
                }
                catch (FormatException)
                {
                    error = true;
                    MessageBox.Show("Въвели сте символ, различен от разрешените (цифра или точка)!");
                }
            }

            double result = 0;

            if (error == false)
            {
                result = digits.Average();
            }

            averageResult.Text = String.Format("{0:f3}", result);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file|*.txt";
            sfd.FileName = "Text file";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("{0}, номер: {1}, клас: {2}, оценки: {3}, среден успех: {4}", pupilName.Text, pupilNumber.Text, pupilClass.Text, ratings.Text, averageResult.Text);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                try
                {
                    if (int.Parse(pupilNumber.Text) > 99 | int.Parse(pupilNumber.Text) < 1 | pupilNumber.Text == null | pupilNumber.Text.ToString() == "")
                    {
                        MessageBox.Show("Грешен номер! Въведете число от 1 до 99.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Грешен номер! Въведете число от 1 до 99.");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTipName_Popup(object sender, PopupEventArgs e)
        {

        }

        private void clearForm_Click(object sender, EventArgs e)
        {

        }

        private void clearForm_Click_1(object sender, EventArgs e)
        {
            clicked = true;
            pupilName.Clear();
            pupilNumber.Clear();
            pupilClass.Clear();
            ratings.Clear();
            averageResult.Clear();
            clicked = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
