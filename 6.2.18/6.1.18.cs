﻿using System;
using System.Windows.Forms;
using ProgramLogic;

namespace WindowsFormsApp1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ex)
        {
            try
            {
                char a = char.Parse(this.textBox3.Text);
                char b = char.Parse(this.textBox2.Text);

                StringUtilits stringUtilit = new StringUtilits(textBox1.Text);
                textBox1.Text = stringUtilit.ABCloseToEachOther(a, b).ToString();
            }
            catch (FormatException exp)
            {
                MessageBox.Show("Неверный формат данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
