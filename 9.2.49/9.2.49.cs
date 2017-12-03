using System;
using System.Windows.Forms;
using ProgramLogic;
using FormsUtils;

namespace GridViewIdex
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }
        //Загрузка меню  - формы
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //LoadFileDialog - Отображает диалоговое окно, с помощью которого пользователь может выбрать файл.
            //IntialDirectory - Возвращает или задает начальную папку, отображенную диалоговым окном файла.
            //Environment.CurrentDirectory - Возвращает или задает полный путь к текущей рабочей папке.
            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory; 
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            //InitGridForArr
            // Инициализация DataGridView для работы с массивами (различные настройки и обработчики событий);
            // при добавление кнопок управления кол-вом строк и столбцов уменьшает размеры DataGridView

            DataGridViewUtils.InitGridForArr(inputGridView, 40, false, true, true, true, true); 
        }
        //Выполнить:
        private void ProcessBtn_Click(object sender, EventArgs ex)
        {
            try
            {
                //GridToArray2 -  Создание двухмерного массива из данных в DataGridView
                int[,] matrix = DataGridViewUtils.GridToArray2<int>(inputGridView);
                //Создаем ответ, с которым будем работать
                MatrixUtils<int> utils = new MatrixUtils<int>(matrix);

                string answer = "Индексы: " + Environment.NewLine;

                //Т.к. наши ответы - индексы типа кортеж, то в объекте, к оторому применили метод находим и выписываем ответ
                foreach (Tuple<int, int> indexes in utils.GetEvenElementsWithOddIndexesSum()) //кортежи
                {
                    answer += String.Format("[{0}, {1}], ", indexes.Item1, indexes.Item2);
                }

                answer = answer.Remove(answer.Length - 2);
                //Запись ответа в лейбл
                OutputText.Text = answer;
            }
            catch (Exception e)
            {
                MessagesUtils.ShowError(e.Message);
            }
        }
        //Файл - Открыть
        private void MainMenuFileOpen_Click(object sender, EventArgs ev)
        {
            //OpenFileDialog - Отображает диалоговое окно, позволяющее пользователю открыть файл. Этот класс не наследуется.
            if (LoadFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string matrixText = FileUtils.ReadStringFromFile(LoadFileDialog.FileName);
                    int[,] matrix = ConvertUtils.ConvertStrToMatrix(matrixText);

                    // Array2ToGrid - Запись данных из двухмерного массива в DataGridView
                    DataGridViewUtils.Array2ToGrid(inputGridView, matrix);

                    MessagesUtils.Show("Данные загружены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }
        //Файл - Сохранить
        private void MainMenuFileSave_Click(object sender, EventArgs ev)
        {
            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string matrixText = ConvertUtils.ConvertMatrixToStr(DataGridViewUtils.GridToArray2<int>(inputGridView));
                FileUtils.WriteStringToFile(SaveFileDialog.FileName, matrixText);

                MessagesUtils.Show("Данные сохранены");
            }
        }
        //Файл - Закрыть
        private void MainMenuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
