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
using ProgramLogic;

namespace Classist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8118_Click(object sender, EventArgs e)
        {
            // Читаем лист из формы
            try
            {
                List<int> mylist = ConvertUtils.StrToList<int>(this.textBox1Progress.Text);

                if (mylist.Count == 0)
                    throw new Exception("Неверный формат данных! Введите массив");

                ClassList ts = new ClassList(mylist);

                string answer = "";
                answer += "Ваша прогрессия:" + ts.CheckArifmeticts();
                this.labelOut.Text = answer;
            }
            catch (FormatException exp) // keep the obj of exception ... выбрасывается неверный формат данных 
            {
                MessageBox.Show("Это не последовательность чисел. Введите корректные данные", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);//exp.Message keeps the mes. that Exception contains
            }
        }
    }
}
