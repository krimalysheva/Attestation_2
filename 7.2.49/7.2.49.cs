using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;
using Sequence1;

namespace Sequence1
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем массив из формы
                int[] sourceArray = ConvertUtils.StrToArray<int>(this.textBox1.Text);
                ArrayTransformatorUtils ts = new ArrayTransformatorUtils(sourceArray);

                // Составляем ответ
                string answer = "";
                int outfirstIndex;
                int outarrayLenght;
                ts.FindSubMaxSequence(out outarrayLenght, out outfirstIndex);

                answer += "Позиция первого элемента : " + outfirstIndex + Environment.NewLine;

                answer += "Число членов : " + outarrayLenght + Environment.NewLine;

                this.label2.Text = answer;
            }
            catch (FormatException exp) // keep the obj of exception ... выбрасывается неверный формат данных 
            {
                MessageBox.Show("Это не последовательность чисел. Введите корректные данные", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
