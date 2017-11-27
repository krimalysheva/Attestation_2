using System;
using System.Windows.Forms;
using ProgramLogic;

namespace Sequence1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем массив из формы
                int[] sourceArray = ConvertUtils.StrToArray<int>(this.textBox1.Text);

                if (sourceArray.Length == 0)
                    throw new Exception("Введите массив");

                ArrayTransformator ts = new ArrayTransformator(sourceArray);
                // Составляем ответ
                string answer = "";

                answer += "Увеличенная длина: " +
                    ConvertUtils.ArrayToStr(ts.ChangeSeriasLength(ChangeSeriaLengthMode.Increase)) +
                    Environment.NewLine;

                answer += "Уменьшенная длина: " +
                    ConvertUtils.ArrayToStr(ts.ChangeSeriasLength(ChangeSeriaLengthMode.Decrease));

                this.label2Out.Text = answer;
            }
            catch (FormatException exp)
            {
                MessageBox.Show("Неверный формат данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
